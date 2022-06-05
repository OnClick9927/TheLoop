using IFramework.Singleton;
using LoopSever.Project.Game.Define;
using LoopSever.Project.Game.Handlers.Battle;
using LoopSever.Project.Game.Peers.Appearance;
using LoopSever.Project.Net;

namespace LoopSever.Project.Game.Handlers.Match;

public class MatchHall : Singleton<MatchHall>
{
    private Dictionary<RoomType, MatchRoom> roomMap = new Dictionary<RoomType, MatchRoom>();
    protected override void OnSingletonInit()
    {
        roomMap.Add(RoomType.Normal, new NormalMatchRoom());

        ServerInstance.env.BindUpdate(Update);
    }

    private void Update()
    {
        foreach (var item in roomMap.Values)
        {
            item.Update();
        }
    }
    public bool ExistRoom(RoomType roomType)
    {
        return roomMap.ContainsKey(roomType);
    }
    public (bool success, RoomType type) Match(RoomType roomType, long role)
    {
        foreach (var item in roomMap)
        {
            if (item.Value.ExistPlayer(role))
            {
                return (false, item.Key);
            }
        }
        var room = roomMap[roomType];
        return (room.EnterPlayer(role), roomType);
    }

    public (bool success, RoomType type) CancelMatch(RoomType roomType, long role)
    {
        foreach (var item in roomMap)
        {
            if (item.Value.ExistPlayer(role))
            {
                if (item.Key != roomType)
                {
                    return (false, item.Key);
                }
            }
        }
        var room = roomMap[roomType];
        return (room.RemovePlayer(role), roomType);
    }

    public void MatchSuccess(MatchRoom match, long[] roles)
    {
        var room = BattleHall.instance.CreateRoon(match.type, roles);
        var id = room.guid.ToString();
        SPMatchSucess sp = new SPMatchSucess();
        sp.Roles = roles;
        sp.RoomID = id;
        sp.RoomType = match.type;
        foreach (var role in roles)
        {
            NetServerHelper.SendResponse(role, sp);
            foreach (var item in roles)
            {
                var token = NetServerHelper.GetToken(role);
                NetServerHelper.GetPeer<GetAppearancePeer>()?.PushAppearances(token, item);
            }
        }
    }

    protected override void OnDispose()
    {

    }
}
