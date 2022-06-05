using IFramework.Net;
using LoopSever.Project.Game.Define;
using LoopSever.ServerCore.Modules.NetCore;
using LoopSever.Project.Game.Handlers.Battle;

namespace LoopSever.Project.Game.Peers.Battle;

[RequestHandler(typeof(CSTurnSelect))]
public class TurnSelect : GamePeer
{
    public override void OnRecieve(SocketToken sToken, IRequest request)
    {
        CSTurnSelect? req = request as CSTurnSelect;
        if (req == null) return;
        var guid = new Guid(req.RoomID);
        var uid = req.Uid;
        var room = BattleHall.instance.FindRoom(guid);
        SCTurnSelect rsp = new SCTurnSelect();

        rsp.SelectIndex = uid;
        var role = GetRoleID(sToken);
        rsp.RoleID = role;
        if (room != null)
        {
            if (room.HasRole(role))
            {
                rsp.Code = BattleErrCode.NotExistRole;
            }
            else
            {
                if (room.SetSelectCard(role, uid))
                {
                    rsp.Code = BattleErrCode.Success;

                }
                else
                {
                    rsp.Code = BattleErrCode.CanNotSelectTheCard;

                }
            }
        }
        else
        {
            rsp.Code = BattleErrCode.NotExistRoom;
        }
        if (rsp.Code == BattleErrCode.Success)
        {
            var roles = room.GetReadyRoles();
            foreach (var _role in roles)
            {
                SendResponse(_role, rsp);
            }
        }
        else
        {
            SendResponse(sToken, rsp);
        }

    }
}
