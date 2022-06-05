using IFramework.Net;
using LoopSever.Project.Game.Define;
using LoopSever.ServerCore.Modules.NetCore;
using LoopSever.Project.Game.Handlers.Battle;

namespace LoopSever.Project.Game.Peers.Battle;

[RequestHandler(typeof(CSBattleReady))]
internal class BattleReadyPeer : GamePeer
{
    public override void OnRecieve(SocketToken sToken, IRequest request)
    {
        CSBattleReady? req = request as CSBattleReady;
        if (req == null) return;
        var guid = new Guid(req.RoomID);
        var role = GetRoleID(sToken);
        var room = BattleHall.instance.FindRoom(guid);
        SCBattleReady rsp = new SCBattleReady();

        if (room != null)
        {
            var ready = room.IsReady(role);
            if (ready)
            {
                rsp.Code = BattleErrCode.DontSendTwice;
            }
            else
            {
                var success = room.SetReadyRole(role);
                if (success)
                {
                    rsp.Code = BattleErrCode.Success;
                    rsp.Roles = room.GetReadyRoles();
                }
                else
                {
                    rsp.Code = BattleErrCode.NotExistRole;
                }
            }

        }
        else
        {
            rsp.Code = BattleErrCode.NotExistRoom;
        }
        SendResponse(sToken, rsp);
    }
}
