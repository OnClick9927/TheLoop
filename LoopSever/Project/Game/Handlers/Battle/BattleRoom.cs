using LoopSever.Project.Game.Define;

namespace LoopSever.Project.Game.Handlers.Battle;

public abstract class BattleRoom
{
    protected List<long> roles;
    private List<long> ready = new List<long>();
    private List<long> aniRoles = new List<long>();

    public Guid guid = Guid.NewGuid();
    public void SetPlayers(long[] roles)
    {
        this.roles = new List<long>(roles);
    }
    public long[] GetReadyRoles() { return this.ready.ToArray(); }
    public bool IsReady(long role) { return ready.Contains(role); }
    public bool SetReadyRole(long role)
    {
        if (!roles.Contains(role))
            return false;
        ready.Add(role);
        if (ready.Count == roles.Count)
        {
            OnGameReady();
        }
        return true;
    }
    public bool HasRole(long role)
    {
        return roles.Contains(role);
    }
    protected abstract void OnGameReady();
    protected void PushRolesReady(Dictionary<long, CardList> cards)
    {
        BattleHall.instance.PushRolesReady(this, cards);
    }
    protected void PushTurnBegin(int turn)
    {
        aniRoles.Clear();
        BattleHall.instance.PushTurnBegin(this, turn);
    }

    public abstract bool SetSelectCard(long role, int uid);
    public async void SetAniEnd(long role)
    {
        aniRoles.Add(role);
        if (aniRoles.Count == roles.Count)
        {
            await Task.Delay(500);
            BeginNewTurn();
        }
    }
    public abstract void BeginNewTurn();
}
