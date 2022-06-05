using IFramework.Net;
using LoopSever.Project.Db;
using LoopSever.Project.Game.Define;
using LoopSever.ServerCore.Modules.NetCore;
using LoopSever.ServerCore.Plugins;
using IFramework;
using LoopSever.Project.Game.Peers.Item;
using LoopSever.Project.Net;
using LoopSever.Project.Game.Peers.Appearance;

namespace LoopSever.Project.Game.Peers.Role
{
    [RequestHandler(typeof(CSRoleLogin))]
    internal class RoleLoginPeer : GamePeer
    {
        public override async void OnRecieve(SocketToken sToken, IRequest request)
        {
            CSRoleLogin? req = request as CSRoleLogin;
            if (req == null) return;
            RoleDB db = GetDB<RoleDB>();
            SCRoleLogin rsp = new SCRoleLogin()
            {
                loginType = req.loginType,
            };
            switch (req.loginType)
            {
                case LoginType.Login:
                    {
                        var id = req.RoleID;
                        var Password = req.Password;
                        var find = await db.ExistRole(id);
                        if (find)
                        {
                            var _psd = Verifier.GetStringMD5(id.ToString());
                            if (_psd == Password)
                            {
                                rsp.Code = LoginErrCode.Success;
                                rsp.Password = Password;
                                rsp.RoleID = id;
                            }
                            else
                            {
                                rsp.Code = LoginErrCode.PasswordErr;
                            }
                        }
                        else
                        {
                            rsp.Code = LoginErrCode.NotExistRoleID;
                        }
                    }
                    break;
                case LoginType.Signin:
                    {
                        var id = IdGeneratorMgr.instance.CreateId();
                        var Password = Verifier.GetStringMD5(id.ToString());
                        await db.CreateRole(id);
                        rsp.Code = LoginErrCode.Success;
                        rsp.Password = Password;
                        rsp.RoleID = id;
                    }
                    break;
            }
            SendResponse(sToken, rsp);
            if (rsp.Code == LoginErrCode.Success)
            {
                NetPlayersData netPlayers = ServerInstance.GetClientsData();
                netPlayers.OnRoleLogIn(rsp.RoleID, sToken);
                GetPeer<ItemCountPeer>()?.PushItems(rsp.RoleID);
                GetPeer<GetAppearancePeer>()?.PushAppearances(sToken, rsp.RoleID);
            }
        }
    }
}
