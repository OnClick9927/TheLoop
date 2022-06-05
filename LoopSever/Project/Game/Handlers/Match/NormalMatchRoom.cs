using LoopSever.Project.Game.Define;
using LoopSever.ServerCore.Utils;
using Random = LoopSever.ServerCore.Utils.Random;

namespace LoopSever.Project.Game.Handlers.Match;

public class NormalMatchRoom : MatchRoom
{
    public override RoomType type => RoomType.Normal;

    protected override void OnUpdate()
    {
        if (roles.Count < 2) return;
        var _1 = Random.Range(0, roles.Count);
        var _2 = Random.Range(0, roles.Count);
        if (_1!=_2)
        {
            this.MatchSuccess(new long[]
            {
                roles[_1],
                roles[_2]
            });
        }
    }
}
