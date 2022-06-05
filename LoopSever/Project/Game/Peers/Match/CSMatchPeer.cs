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

[RequestHandler(typeof(CSMatch))]
internal class CSMatchPeer : GamePeer
{
    public override void OnRecieve(SocketToken sToken, IRequest request)
    {
        CSMatch? req = request as CSMatch;
        if (req == null) return;
        var type = req.RoomType;
        SCMatch rsp = new SCMatch();
        rsp.RoomType = type;
        var exist = MatchHall.instance.ExistRoom(type);
        if (exist)
        {
            rsp.Code = MatchErrCode.RoomTypeNotOpen;
        }
        else
        {
            var role = GetRoleID(sToken);
            var result = MatchHall.instance.Match(type, role);
            if (result.success)
            {
                rsp.Code = MatchErrCode.Success;
            }
            else
            {
                rsp.Code = MatchErrCode.AlreadyInRoom;
                rsp.RoomType = result.type;
            }
        }
        SendResponse(sToken, rsp);
    }
}
