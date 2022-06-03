using IFramework.Net;
using LoopSever.Project.Db;
using LoopSever.Project.Game.Define;
using LoopSever.ServerCore.Modules.NetCore;
using LoopSever.ServerCore.Plugins;
using IFramework;

namespace LoopSever.Project.Game.Peers.Item
{
    [RequestHandler(typeof(CSItemCount))]
    internal class ItemCountPeer : GamePeer
    {
        public override void OnRecieve(SocketToken sToken, IRequest request)
        {
            var roleID = GetRoleID(sToken);
            PushItems(roleID);
        }
        public async void PushItems(long roleID)
        {
            ItemDB ItemDB = GetDB<ItemDB>();
            var list = await ItemDB.GetItems(roleID);
            
            var dic = list?.ConvertAll(info => new { info.ItemID, info.Count })
                 .ToDictionary((a) => a.ItemID, a => a.Count);
            SPItemCount sp = new SPItemCount();
            sp.items = dic;
            SendResponse(roleID, sp);
        }

        public async Task<bool> PushItemsChange(long roleID, Dictionary<long, int> changes)
        {
            ItemDB ItemDB = GetDB<ItemDB>();
            SPItemCountChange sp = new SPItemCountChange();
            sp.items = new Dictionary<long, int>();
            foreach (var item in changes)
            {
                var itemID = item.Key;
                var count = item.Value;
                var have = await ItemDB.GetCount(roleID, itemID);
                have += count;
                if (have < 0)
                    return false;
                ItemDB.SetItem(roleID, itemID, have);
                sp.items.Add(itemID, have);
            }
            SendResponse(roleID, sp);
            return true;
        }
    }
}
