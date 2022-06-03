using System.ComponentModel.DataAnnotations;

namespace LoopSever.ServerCore.Modules.Db;

public class ModelBase
{
    [Key]
    public int id { get; set; }
}
