using IFramework.Net;
using LoopSever.Project.Db;
using LoopSever.Project.Game.Define;
using LoopSever.ServerCore.Modules.NetCore;

namespace LoopSever.Project.Game.Peers.Appearance
{
    [RequestHandler(typeof(CSSetAppearance))]
    internal class SetAppearancePeer : GamePeer
    {
        public override async void OnRecieve(SocketToken sToken, IRequest request)
        {
            CSSetAppearance? req = request as CSSetAppearance;
            if (req == null) return;
            ItemDB itemDB = GetDB<ItemDB>();
            var ItemID = req.ItemID;
            var AppearanceID = req.AppearanceID;
            var role = GetRoleID(sToken);
            var count = await itemDB.GetCount(role, ItemID);
            SCSetAppearance rsp = new SCSetAppearance();
            rsp.AppearanceID = AppearanceID;
            rsp.ItemID = ItemID;
            if (count > 0)
            {
                rsp.Code = AppearanceErrCode.Success;
                AppearanceDB appearanceDB = GetDB<AppearanceDB>();
                await appearanceDB.SetAppearances(role, AppearanceID, ItemID);
            }
            else
            {
                rsp.Code = AppearanceErrCode.ItemNotEnuough;
            }
            SendResponse(sToken, rsp);
        }
    }
}
