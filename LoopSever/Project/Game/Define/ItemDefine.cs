using LoopSever.Project.Define;
using LoopSever.ServerCore.Modules.NetCore;

namespace LoopSever.Project.Game.Define;


[NetMessageCode(ModuleDefine.Item, 1)]
public class CSItemCount : IRequest
{

}

[NetMessageCode(ModuleDefine.Item, 1)]
public class SPItemCount : IResponse
{
    public int Code { get; set; }
    public Dictionary<long, int> items;
}

[NetMessageCode(ModuleDefine.Item, 2)]
public class SPItemCountChange : IResponse
{
    public int Code { get; set; }
    public Dictionary<long, int> items;
}