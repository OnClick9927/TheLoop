using LoopSever.ServerCore.Modules.Db;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopSever.Project.Db;

public class AppearanceInfo : ModelBase
{
    public long RoleID { get; set; }
    public long ItemID { get; set; }
    public long AppearanceID { get; set; }
}
internal class AppearanceDB : SqliteDbContext
{
    public DbSet<AppearanceInfo> Appearances { get; set; }

    public async Task<List<AppearanceInfo>?> GetAppearance(long RoleID)
    {
        var count = await Appearances.CountAsync();
        if (count == 0) return default;
        var q = Appearances.Where(a => a.RoleID == RoleID);
        return await q.ToListAsync();
    }
    public async Task SetAppearances(long RoleID, long AppearanceID, long ItemID)
    {
        var count = await Appearances.CountAsync();
        bool exist = false;
        if (count != 0)
        {
            var find = await Appearances
                .Where(x => x.RoleID == RoleID && x.AppearanceID == AppearanceID)
                .FirstOrDefaultAsync();
            if (find != null)
            {
                exist = true;
                find.ItemID = ItemID;
                Update(find);
            }
        }
        if (!exist)
        {
            await Appearances.AddAsync(new AppearanceInfo()
            {
                RoleID = RoleID,
                AppearanceID = AppearanceID,
                ItemID = ItemID
            });
        }
        await SaveChangesAsync();
    }
}
