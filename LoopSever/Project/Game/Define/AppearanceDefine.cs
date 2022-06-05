using LoopSever.Project.Define;
using LoopSever.ServerCore.Modules.NetCore;

namespace LoopSever.Project.Game.Define;

[NetMessageCode(ModuleDefine.Appearance, 1)]
public class CSGetAppearance : IRequest
{
    public long RoleID { get; set; }
}

[NetMessageCode(ModuleDefine.Appearance, 1)]
public class SCGetAppearance : IResponse
{
    public int Code { get; set; }
    public long RoleID { get; set; }

    public Dictionary<long, long> Appearance { get; set; }// 形象ID，道具号码

}
[NetMessageCode(ModuleDefine.Appearance, 2)]
public class CSSetAppearance : IRequest
{
    public long ItemID { get; set; }
    public long AppearanceID { get; set; }
}
[NetMessageCode(ModuleDefine.Appearance, 2)]
public class SCSetAppearance : IResponse
{
    public int Code { get; set; }
    public long ItemID { get; set; }
    public long AppearanceID { get; set; }
}


[NetworkErrCodeDefine]
internal class AppearanceErrCode : ErrCodeDefine
{
    public static int ItemNotEnuough = 2;
}
