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
            SPItemCount rsp = new SPItemCount();
            rsp.items = new ItemDic() { items = dic };
            SendResponse(roleID, rsp);
        }

        public async Task<bool> PushItemsChange(long roleID, ItemDic changes)
        {
            ItemDB ItemDB = GetDB<ItemDB>();
            SPItemCountChange rsp = new SPItemCountChange();
            rsp.items = changes;
            if (changes.items != null)
            {
                foreach (var item in changes.items)
                {
                    var itemID = item.Key;
                    var count = item.Value;
                    var have = await ItemDB.GetCount(roleID, itemID);
                    have += count;
                    if (have < 0)
                        return false;
                    ItemDB.SetItem(roleID, itemID, have);
                    rsp.items.items.Add(itemID, have);
                }
            }
    
            SendResponse(roleID, rsp);
            return true;
        }
    }
}
