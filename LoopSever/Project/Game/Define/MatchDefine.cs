using LoopSever.Project.Define;
using LoopSever.ServerCore.Modules.NetCore;

namespace LoopSever.Project.Game.Define;

public enum RoomType
{
    Normal
}
[NetMessageCode(ModuleDefine.Match, 1)]
public class CSMatch : IRequest
{
    public RoomType RoomType { get; set; }
}


[NetMessageCode(ModuleDefine.Match, 1)]
public class SCMatch : IResponse
{
    public int Code { get; set; }
    public RoomType RoomType { get; set; }

}

[NetMessageCode(ModuleDefine.Match, 2)]
public class CSCancelMatch : IRequest
{
    public RoomType RoomType { get; set; }
}

[NetMessageCode(ModuleDefine.Match, 2)]
public class SCCancelMatch : IResponse
{
    public int Code { get; set; }
    public RoomType RoomType { get; set; }

}

[NetMessageCode(ModuleDefine.Match, 3)]
public class SPMatchSucess : IResponse
{
    public int Code { get; set; }
    public RoomType RoomType { get; set; }

    public string RoomID { get; set; }
    public long[] Roles { get; set; }
}
[NetworkErrCodeDefine]
public class MatchErrCode : ErrCodeDefine
{
    public static int RoomTypeNotOpen = 2;
    public static int AlreadyInRoom = 3;
    public static int RoomTypeNotExistRole = 4;
    public static int RoleInAnotherRoomType = 4;

}