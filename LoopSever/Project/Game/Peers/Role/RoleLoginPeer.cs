using IFramework.Net;
using LoopSever.Project.Db;
using LoopSever.Project.Game.Define;
using LoopSever.ServerCore.Modules.NetCore;
using LoopSever.ServerCore.Plugins;
using IFramework;
using LoopSever.Project.Game.Peers.Item;
using LoopSever.Project.Net;

namespace LoopSever.Project.Game.Peers.Role
{
    [RequestHandler(typeof(CSRoleLogin))]
    internal class RoleLoginPeer : GamePeer
    {
        public override async void OnRecieve(SocketToken sToken, IRequest request)
        {
            CSRoleLogin cSRoleLogin = request as CSRoleLogin;
            if (cSRoleLogin == null) return;
            RoleDB db = GetDB<RoleDB>();
            SCRoleLogin roleLogin = new SCRoleLogin()
            {
                loginType = cSRoleLogin.loginType,
            };
            switch (cSRoleLogin.loginType)
            {
                case LoginType.Login:
                    {
                        var id = cSRoleLogin.RoleID;
                        var Password = cSRoleLogin.Password;
                        var find = await db.ExistRole(id);
                        if (find)
                        {
                            var _psd = Verifier.GetStringMD5(id.ToString());
                            if (_psd == Password)
                            {
                                roleLogin.Code = LoginErrCode.Success;
                                roleLogin.Password = Password;
                                roleLogin.RoleID = id;
                            }
                            else
                            {
                                roleLogin.Code = LoginErrCode.PasswordErr;
                            }
                        }
                        else
                        {
                            roleLogin.Code = LoginErrCode.NotExistRoleID;
                        }
                    }
                    break;
                case LoginType.Signin:
                    {
                        var id = IdGeneratorMgr.instance.CreateId();
                        var Password = Verifier.GetStringMD5(id.ToString());
                        await db.CreateRole(id);
                        roleLogin.Code = LoginErrCode.Success;
                        roleLogin.Password = Password;
                        roleLogin.RoleID = id;
                    }
                    break;
            }
            SendResponse(sToken, roleLogin);
            if (roleLogin.Code == LoginErrCode.Success)
            {
                NetPlayersData netPlayers = ServerInstance.GetClientsData();
                netPlayers.OnRoleLogIn(roleLogin.RoleID, sToken);
                GetPeer<ItemCountPeer>()?.PushItems(roleLogin.RoleID);
            }
        }
    }
}
