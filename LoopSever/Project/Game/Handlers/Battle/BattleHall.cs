using IFramework.Singleton;
using LoopSever.Project.Game.Define;
using LoopSever.Project.Net;
using LoopSever.ServerCore.Utils;

namespace LoopSever.Project.Game.Handlers.Battle;
internal class BattleHall : Singleton<BattleHall>
{
    private Dictionary<Guid, BattleRoom> rooms = new Dictionary<Guid, BattleRoom>();
    protected override void OnSingletonInit()
    {

    }
    public BattleRoom CreateRoon(RoomType type, long[] roles)
    {
        BattleRoom room = null;
        switch (type)
        {
            case RoomType.Normal:
                room = new NormalBattleRoom();
                break;
            default:
                break;
        }
        room.SetPlayers(roles);
        rooms.Add(room.guid, room);
        return room;
    }

    public BattleRoom? FindRoom(Guid guid)
    {
        if (rooms.ContainsKey(guid))
        {
            return rooms[guid];
        }
        return default;

    }
    public void PushRolesReady(BattleRoom room, Dictionary<long, CardList> cards)
    {
        SPBattleAllReady rsp = new SPBattleAllReady();
        rsp.Cards = new CardDic() { Cards = cards };
        var roles = room.GetReadyRoles();
        foreach (var role in roles)
        {
            NetServerHelper.SendResponse(role, rsp);
        }
    }

    public void PushTurnBegin(BattleRoom room, int turn)
    {
        SPTurnBegin rsp = new SPTurnBegin();
        rsp.Turn = turn;
        var roles = room.GetReadyRoles();
        foreach (var role in roles)
        {
            NetServerHelper.SendResponse(role, rsp);
        }
    }

    protected override void OnDispose()
    {

    }
}
