using IFramework.Net;
using LoopSever.Project.Db;
using LoopSever.Project.Game.Define;
using LoopSever.ServerCore.Modules.NetCore;
using LoopSever.ServerCore.Plugins;
using IFramework;
using LoopSever.Project.Game.Peers.Item;
using LoopSever.Project.Net;
using LoopSever.Project.Game.Handlers.Match;
namespace LoopSever.Project.Game.Peers.Match;

[RequestHandler(typeof(CSCancelMatch))]
internal class CSCancelMatchPeer : GamePeer
{
    public override void OnRecieve(SocketToken sToken, IRequest request)
    {
        CSCancelMatch? req = request as CSCancelMatch;
        if (req == null) return;
        var type = req.RoomType;
        SCCancelMatch rsp = new SCCancelMatch();
        rsp.RoomType = type;
        var exist = MatchHall.instance.ExistRoom(type);
        if (exist)
        {
            rsp.Code = MatchErrCode.RoomTypeNotOpen;
        }
        else
        {
            var role = GetRoleID(sToken);
            var result = MatchHall.instance.CancelMatch(type, role);
            if (result.success)
            {
                rsp.Code = MatchErrCode.Success;
            }
            else
            {
                if (result.type == type)
                {
                    rsp.Code = MatchErrCode.RoomTypeNotExistRole;
                }
                else
                {
                    rsp.Code = MatchErrCode.RoleInAnotherRoomType;
                }
            }
        }
        SendResponse(sToken, rsp);
    }
}