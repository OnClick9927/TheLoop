using LoopSever.ServerCore.Modules.Db;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopSever.Project.Db;
public class ItemInfo : ModelBase
{
    public long ItemID { get; set; }
    public long RoleID { get; set; }
    public int Count { get; set; }
}
internal class ItemDB : SqliteDbContext
{
    public DbSet<ItemInfo> Items { get; set; }

    public async void SetItem(long roleID, long itemID, int count)
    {
        ItemInfo? info = await GetItem(roleID, itemID);
        if (info == null)
        {
            Items.Add(new ItemInfo
            {
                Count = count,
                ItemID = itemID,
                RoleID = roleID
            });
        }
        else
        {
            info.Count = count;
            Update(info);
        }
        await SaveChangesAsync();
    }
    public async Task<List<ItemInfo>?> GetItems(long roleID)
    {
        var count = await Items.CountAsync();
        if (count == 0) return default;
        var q = Items.Where(x => x.RoleID == roleID);
        count = await q.CountAsync();
        if (count == 0) return default;
        return await q.ToListAsync();
    }

    public async Task<ItemInfo?> GetItem(long roleID, long itemID)
    {
        var count = await Items.CountAsync();
        if (count == 0) return default;
        var q = Items.Where(x => x.RoleID == roleID && x.ItemID == itemID);
        count = await q.CountAsync();
        if (count == 0) return default;
        return await q.FirstOrDefaultAsync();
    }
    public async Task<int> GetCount(long roleID, long itemID)
    {
        ItemInfo? info = await GetItem(roleID, itemID);
        if (info == null) return 0;
        return info.Count;
    }

}
