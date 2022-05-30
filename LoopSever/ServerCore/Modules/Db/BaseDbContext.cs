using IFramework;
using Microsoft.EntityFrameworkCore;

namespace LoopSever.ServerCore.Modules.Db;

public abstract class BaseDbContext : DbContext
{
    protected abstract string ConnectionString { get; }

    private readonly Dictionary<Type, bool> _entityTypesDir = new Dictionary<Type, bool>();

    public  DbConf DbConf { get; set; }

    public  ModelBuilder ContextModelBuilder { get; set; }

    public BaseDbContext(DbConf sqlConf) : base()
    {
        DbConf = sqlConf;
    }

    /// <summary>
    /// 1 调用配置 执行返回
    /// </summary>
    /// <param name="optionsBuilder"></param>
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

    /// <summary>
    /// 调用 创建 每一个 table 实例 回调
    /// </summary>
    /// <param name="modelBuilder"></param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        foreach (var item in _entityTypesDir)
        {
            if (item.Value == false)
            {
                modelBuilder.Entity(item.Key);
                _entityTypesDir[item.Key] = true;
            }
        }

        base.OnModelCreating(modelBuilder);
        ContextModelBuilder = modelBuilder;
        Log.L("OnModelCreating");
    }


    public DbSet<TEntity> AddSet<TEntity>() where TEntity : class
    {
        var type = typeof(TEntity);
        if (!_entityTypesDir.ContainsKey(type))
        {
            _entityTypesDir.Add(type, false);
            if (ContextModelBuilder != null)
            {
                this.OnModelCreating(ContextModelBuilder);
            }
        }
        return Set<TEntity>();
    }
    
    public void Destroy()
    {
        _entityTypesDir.Clear();
        Dispose();
    }
}