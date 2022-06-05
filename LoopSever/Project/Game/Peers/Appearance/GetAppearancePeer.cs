using IFramework.Net;
using LoopSever.Project.Db;
using LoopSever.Project.Game.Define;
using LoopSever.ServerCore.Modules.NetCore;
using LoopSever.ServerCore.Plugins;
using IFramework;

namespace LoopSever.Project.Game.Peers.Appearance
{
    [RequestHandler(typeof(CSGetAppearance))]
    internal class GetAppearancePeer : GamePeer
    {
        public override async void OnRecieve(SocketToken sToken, IRequest request)
        {
            CSGetAppearance? req = request as CSGetAppearance;
            if (req == null) return;
            await PushAppearances(sToken, req.RoleID);
        }

        public async Task PushAppearances(SocketToken? sToken, long roleID)
        {
            AppearanceDB db = GetDB<AppearanceDB>();
            SCGetAppearance rsp = new SCGetAppearance();

            var list = await db.GetAppearance(roleID);
            var dic = list?.ConvertAll(info => new { info.AppearanceID, info.ItemID })
               .ToDictionary((a) => a.AppearanceID, a => a.ItemID);
            rsp.RoleID = roleID;
            rsp.Appearance = dic;
            SendResponse(sToken, rsp);
        }
    }
}
