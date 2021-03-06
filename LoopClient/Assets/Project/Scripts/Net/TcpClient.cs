using IFramework;
using IFramework.Net;
using IFramework.Net.Tcp;
using IFramework.Packets;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
namespace LoopClient
{
    public interface IResponse { }
    public interface IRequest { }
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    class NetMessageCode : Attribute
    {
        public uint MainId;
        public uint SubId;
        public NetMessageCode(uint mainId, uint subId)
        {
            this.MainId = mainId;
            this.SubId = subId;
        }
    }
    class TcpClient
    {
        public TcpClient(string ip,int port)
        {
            this.ip = ip;
            this.port = port;
        }
        private ITcpClientProvider client;
        private int port = 9633;
        private string ip = "127.0.0.1";
        private Dictionary<Type, string> requstMap;
        private Dictionary<string, Type> responseMap;
        private PacketReader reader = new PacketReader(1024 * 1024);
        private Encoding en = Encoding.UTF8;
        public bool connected { get { return client.IsConnected; } }
        public event Action<Type, IResponse> onResponse;
        public event Action<uint, uint, string> onLuaResponse;
        public event Action onConnect, onDisconnect;
        private void Init()
        {
            responseMap = typeof(IResponse).GetSubTypesInAssemblys().ToList().ConvertAll((type) =>
            {
                NetMessageCode h =
                    type.GetCustomAttributes(typeof(NetMessageCode), false).First() as NetMessageCode;
                return new { type, h.MainId, h.SubId };
            }).ToDictionary(
                    (a) => a.MainId + "-" + a.SubId,
                    (a) => a.type
                );


            requstMap = typeof(IRequest).GetSubTypesInAssemblys().ToList().ToDictionary(
                    (a) => a,
                    (type) =>
                    {
                        NetMessageCode h =
                            type.GetCustomAttributes(typeof(NetMessageCode), false).First() as NetMessageCode;
                        return h.MainId + "-" + h.SubId;
                    }
                );
            Launcher.env.BindDispose(Dispose);
            client = NetTool.CreateTcpClient();
            client.ReceivedOffsetCallback += OnRecieve;
            client.ConnectedCallback += OnConnect;
            client.DisconnectedCallback += OnDIsConnect;
        }

        private void Dispose()
        {
            if (client != null)
            {
                client.Disconnect();
            }
        }

        public async Task<bool> Connect()
        {
            Init();
            var result = await Task.Run(async () =>
            {
                while (client == null)
                {
                    await Task.Delay(10);
                }
                var _r = client.ConnectTo(port, ip);
                return _r;
            });
            return result;
        }

        private void OnDIsConnect(SocketToken sToken)
        {
            Debug.LogError("??????");
            Launcher.env.WaitEnvironmentFrame(() =>
            {
                onDisconnect?.Invoke();
            });
        }

        private void OnConnect(SocketToken sToken, bool isConnected)
        {
            Debug.LogError("??????");
            Launcher.env.WaitEnvironmentFrame(() =>
            {
                onConnect?.Invoke();
            });

        }
        public void SendLuaRequest(uint code, uint subCode, string json)
        {
            Debug.Log(string.Format("<color=#209DBF>????????????????\n{0}</color>", json));
            var packet = new Packet(1, code, subCode, 1, en.GetBytes(json));
            client?.Send(new SegmentOffset(packet.Pack()));
        }

        public void SendRequest<TRequest>(TRequest req) where TRequest : IRequest
        {
            Debug.Log(string.Format("<color=#209DBF>????????????????\n{0}</color>", JsonUtility.ToJson(req, true)));

            Type type = typeof(TRequest);
            var msgHead = requstMap[type];
            var list = msgHead.Split('-');


            var packet = new Packet(1, Convert.ToUInt32(list[0]), Convert.ToUInt32(list[1]), 1, en.GetBytes(JsonUtility.ToJson(req)));
            client?.Send(new SegmentOffset(packet.Pack()));
        }
        private void OnRecieve(SegmentToken session)
        {
            reader.Set(session.Data.buffer, session.Data.offset, session.Data.size);
            var pkgs = reader.Get();
            if (pkgs == null || pkgs.Count == 0) return;

            for (int i = 0; i < pkgs.Count; i++)
            {
                var pkg = pkgs[i];
                var str = en.GetString(pkg.message);
                Debug.Log(string.Format("<color=#209DBF>??????????????????\n{0}</color>", str));
                var key = pkg.MainId + "-" + pkg.SubId;

                if (responseMap.ContainsKey(key))
                {
                    var type = responseMap[key];
                    IResponse req = JsonUtility.FromJson(str, type) as IResponse;
                    Launcher.env.WaitEnvironmentFrame(() =>
                    {
                        onResponse?.Invoke(type, req);
                    });
                }
                Launcher.env.WaitEnvironmentFrame(() =>
                {
                    onLuaResponse?.Invoke(pkg.MainId, pkg.SubId, str);
                });
            }
        }

    }
}


