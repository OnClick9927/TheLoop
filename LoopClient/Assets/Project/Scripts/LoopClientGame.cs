/*********************************************************************************
 *Author:         爱吃水蜜桃
 *Version:        1.0
 *UnityVersion:   2020.3.30f1c1
 *Date:           2022-04-08
 *Description:    Description
 *History:        2022-04-08--
*********************************************************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using IFramework;
using IFramework.Hotfix.Asset;
using IFramework.Hotfix.Lua;
using IFramework.UI;
using UnityEngine;
namespace LoopClient
{
    [CreateAssetMenu]
    public class LoopClientPanelConfig_RT
    {
        [System.Serializable]
        public class Data
        {
            public string panelName;
            public UILayer layer = UILayer.Common;
            public int layerOrder = 0;
        }
        [SerializeField] public List<Data> datas = new List<Data>();
    }
    [RequireComponent(typeof(LoopClientUpdate))]
    public class LoopClientGame : Game
    {
        public string ip = "127.0.0.1";
        public int port = 9633;
        private TcpClient tcp;
        [HideInInspector]
        public LoopClientUpdate update;
        public bool connected { get { return tcp.connected; } }
        public event Action<Type, IResponse> onResponse
        {
            add
            {
                tcp.onResponse += value;
            }
            remove
            {
                tcp.onResponse -= value;
            }
        }
        public event Action<uint, uint, string> onLuaResponse
        {
            add
            {
                tcp.onLuaResponse += value;
            }
            remove
            {
                tcp.onLuaResponse -= value;
            }
        }
        public event Action onConnect
        {
            add
            {
                tcp.onConnect += value;
            }
            remove
            {
                tcp.onConnect -= value;
            }
        }
        public event Action onDisconnect
        {
            add
            {
                tcp.onDisconnect += value;
            }
            remove
            {
                tcp.onDisconnect -= value;
            }
        }
        public bool AssetCheck = false;

        public void SendLuaRequest(uint code, uint subCode, string json)
        {
            if (tcp == null || !tcp.connected) return;
            tcp.SendLuaRequest(code, subCode, json);
        }
        public void SendRequest<TRequest>(TRequest req) where TRequest : IRequest
        {
            if (tcp == null || !tcp.connected) return;
            tcp.SendRequest(req);
        }
        public class UnityModules
        {
            public IUIModule UpdateUI { get { return Launcher.modules.GetModule<UIModule>("Update", priority: 2); } }
            public IUIModule UI { get { return Launcher.modules.GetModule<UIModule>("Lua", priority: 100); } }
            public AudioModule Audio { get { return Launcher.modules.GetModule<AudioModule>("Audio", priority: 1); } }

            public XLuaModule Lua
            {
                get { return Launcher.modules.GetModule<XLuaModule>(priority: 1); }
            }

        }
        public UnityModules unityModules = new UnityModules();

        public string playerPrefsKey = "4654623498";
        public override void Init()
        {
            LoopClientPerfs.SetKey(playerPrefsKey);
            Application.targetFrameRate = 60;
            update = GetComponent<LoopClientUpdate>();
            unityModules.UpdateUI.CreateCanvas();
            unityModules.UpdateUI.SetGroups(new MvvmGroups(UIMap_MVVM.map));
            unityModules.UpdateUI.AddLoader(new UIUpdateLoader());
            unityModules.UpdateUI.Show(UIMap_MVVM.UpdatePanel);
            unityModules.UpdateUI.canvas.transform.parent = transform;

            unityModules.Audio.root.transform.parent = transform;

            unityModules.Audio.ReadData(LoopClientPerfs.Read<AudioSaveData>("AudioSaveData"));
            env.BindDispose(OnDispose);
        }

        private void OnDispose()
        {
            LoopClientPerfs.Save<AudioSaveData>("AudioSaveData", unityModules.Audio.GetSaveData());
        }
        public async override void Startup()
        {
            update.Check();
        }
        public Canvas UICanvas;
        public async void StartGame()
        {
            this.unityModules.UpdateUI.Close(UIMap_MVVM.UpdatePanel);

            var asset = await Assets.LoadAsset("Assets/Project/Configs/Json/UI.json");
            TextAsset txt = asset.GetAsset<TextAsset>();
           
            LoopClientPanelConfig_RT _configs = JsonUtility.FromJson<LoopClientPanelConfig_RT>(txt.text);

            UILayerConfig[] configs = new UILayerConfig[_configs.datas.Count];
            for (int i = 0; i < _configs.datas.Count; i++)
            {
                configs[i] = new UILayerConfig()
                {
                    layer = _configs.datas[i].layer,
                    order = _configs.datas[i].layerOrder,
                    name = _configs.datas[i].panelName,
                };
            }
            unityModules.UI.SetCanvas(UICanvas);
            unityModules.UI.PutCamera(Camera.main);
            unityModules.UI.AddLoader(new UILoader());
            unityModules.UI.SetLayerConfig(configs);
            unityModules.UI.canvas.transform.parent = this.transform;
            unityModules.UI.canvas.worldCamera = Camera.main;
            unityModules.UI.SetItemLoader(LoadItem);
            Camera.main.transform.SetParent(this.transform, true);
            tcp = new TcpClient(ip,port);
            StartLua();
            await tcp.Connect();
        }

        private GameObject LoadItem(string path)
        {
            var asset = Assets.LoadAsset(path);
            asset.WaitForComplete();
            return asset.GetAsset<GameObject>();
        }

        private void StartLua()
        {
            unityModules.Lua.AddLoader(new AssetsLoader());
            new XluaMain(unityModules.Lua);
        }


    }
}
