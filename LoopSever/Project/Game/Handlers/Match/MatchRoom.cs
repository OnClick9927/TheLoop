using LoopSever.Project.Game.Define;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopSever.Project.Game.Handlers.Match;

public abstract class MatchRoom
{
    public abstract RoomType type { get; }
    protected List<long> roles = new List<long>();
    public bool EnterPlayer(long role)
    {
        if (roles.Contains(role))
        {
            return false;
        }
        roles.Add(role);
        return true;
    }
    public bool RemovePlayer(long role)
    {
        if (!roles.Contains(role))
        {
            return false;
        }
        roles.Remove(role);
        return true;
    }

    public void Update()
    {
        if (roles.Count == 0) return;
        OnUpdate();
    }
    protected abstract void OnUpdate();
    public bool ExistPlayer(long role)
    {
        return roles.Contains(role);
    }

    protected void MatchSuccess(long[] roles)
    {
        for (int i = roles.Length - 1; i >= 0; i--)
        {
            this.roles.Remove(roles[i]);
        }
        MatchHall.instance.MatchSuccess(this, roles);
    }
}
