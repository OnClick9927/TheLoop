using LoopSever.Project.Define;
using LoopSever.ServerCore.Modules.NetCore;

namespace LoopSever.Project.Game.Define;

public class ItemDic
{
    public Dictionary<long, int> items { get; set; }

}

[NetMessageCode(ModuleDefine.Item, 1)]
public class CSItemCount : IRequest
{

}

[NetMessageCode(ModuleDefine.Item, 1)]
public class SPItemCount : IResponse
{
    public int Code { get; set; }
    public ItemDic items { get; set; }
}

[NetMessageCode(ModuleDefine.Item, 2)]
public class SPItemCountChange : IResponse
{
    public int Code { get; set; }
    public ItemDic items { get; set; }
}