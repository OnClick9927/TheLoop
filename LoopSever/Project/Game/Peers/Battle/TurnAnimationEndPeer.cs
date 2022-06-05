using IFramework.Net;
using LoopSever.Project.Game.Define;
using LoopSever.ServerCore.Modules.NetCore;
using LoopSever.Project.Game.Handlers.Battle;

namespace LoopSever.Project.Game.Peers.Battle;

[RequestHandler(typeof(CSTurnAnimationEnd))]

public class TurnAnimationEndPeer : GamePeer
{
    public override void OnRecieve(SocketToken sToken, IRequest request)
    {
        CSTurnAnimationEnd? req = request as CSTurnAnimationEnd;
        if (req == null) return;

        var room = BattleHall.instance.FindRoom(new Guid(req.RoomID));
        if (room == null) return;
        var role = GetRoleID(sToken);
        SCTurnAnimationEnd rsp = new SCTurnAnimationEnd();
        if (room.HasRole(role))
        {
            rsp.Code=BattleErrCode.NotExistRole;
        }
        else
        {
            rsp.Code = BattleErrCode.Success;
            room.SetAniEnd(role);
        }
        SendResponse(sToken, rsp);
    }
}