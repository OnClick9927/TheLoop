using LoopSever.Project.Define;
using LoopSever.ServerCore.Modules.NetCore;

namespace LoopSever.Project.Game.Define;
public enum TurnResultType
{
    DropTwo,
    DropOne,
    Normal,
}
public class CardList
{
    public List<CardInfo> Cards { get; set; }
}
public class CardInfo
{
    public long Id { get; set; }
    public int Uid { get; set; }
}
public class CardDic
{
    public Dictionary<long, CardList> Cards { get; set; }

}

[NetMessageCode(ModuleDefine.Battle, 1)]
public class CSBattleReady : IRequest
{
    public string RoomID { get; set; }
}
[NetMessageCode(ModuleDefine.Battle, 1)]
public class SCBattleReady : IResponse
{
    public int Code { get; set; }
    public long[] Roles { get; set; }
}
[NetMessageCode(ModuleDefine.Battle, 2)]
public class CSTurnSelect : IRequest
{
    public string RoomID { get; set; }
    public int Uid { get; set; }
}
[NetMessageCode(ModuleDefine.Battle, 2)]
public class SCTurnSelect : IResponse
{
    public int Code { get; set; }
    public long RoleID { get; set; }
    public int SelectIndex { get; set; }
}
[NetMessageCode(ModuleDefine.Battle, 3)]
public class CSTurnAnimationEnd : IRequest
{
    public string RoomID { get; set; }
}
[NetMessageCode(ModuleDefine.Battle, 3)]
public class SCTurnAnimationEnd : IResponse
{
    public int Code { get; set; }
}



[NetMessageCode(ModuleDefine.Battle, 4)]
public class SPBattleAllReady : IResponse
{
    public int Code { get; set; }
    public CardDic Cards { get; set; }
}

[NetMessageCode(ModuleDefine.Battle, 5)]
public class SPTurnBegin : IResponse
{
    public int Code { get; set; }
    public int Turn { get; set; }
}

[NetMessageCode(ModuleDefine.Battle, 6)]
public class SPTurnResult : IResponse
{
    public int Code { get; set; }
    public long RoleID { get; set; }   //胜利者
    public TurnResultType Type { get; set; }
    public CardDic Cards { get; set; }

}

[NetMessageCode(ModuleDefine.Battle, 7)]
public class SPTurnTimer : IResponse
{
    public int Code { get; set; }
    public float Second { get; set; }   //回合开始到现在的时间
}

[NetMessageCode(ModuleDefine.Battle, 8)]
public class SPBattleEnd : IResponse
{
    public int Code { get; set; }
    public long RoleID { get; set; }   //胜利者

    public ItemDic Items { get; set; } //奖励的道具
}


[NetworkErrCodeDefine]
public class BattleErrCode : ErrCodeDefine
{
    public static int NotExistRoom = 2;
    public static int DontSendTwice = 3;
    public static int NotExistRole = 4;
    public static int CanNotSelectTheCard = 5;

}