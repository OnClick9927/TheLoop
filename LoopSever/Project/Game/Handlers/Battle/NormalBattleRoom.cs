using LoopSever.Project.Game.Define;
using LoopSever.Project.Game.Peers.Item;
using LoopSever.Project.Net;
using Random = LoopSever.ServerCore.Utils.Random;

namespace LoopSever.Project.Game.Handlers.Battle;

public class NormalBattleRoom : BattleRoom
{
    private Dictionary<long, CardList> cards;
    private Dictionary<long, List<CardInfo>> cards_select;

    int turn = 1;
    int count = 6;
    long role_1 { get { return roles[0]; ; } }
    long role_2 { get { return roles[1]; ; } }

    private bool IsTurnEnd()
    {
        var now = DateTime.Now;
        if ((now - start).TotalSeconds >= 15) return true;
        var isEnd = cards_select[role_1].Count == turn && cards_select[role_2].Count == turn;
        return isEnd;
    }
    private long GetGameWinner()
    {
        foreach (var item in cards)
        {
            if (item.Value.Cards.Count != 0)
            {
                return item.Key;
            }
        }
        return -1;
    }
    public override bool SetSelectCard(long role, int uid)
    {
        var list = cards[role].Cards;
        for (int i = list.Count - 1; i >= 0; i--)
        {
            var item = list[i];
            if (item.Uid == uid)
            {
                cards_select[role].Add(item);
                list.RemoveAt(i);
                return true;
            }
        }
        return false;
    }

    protected async override void OnGameReady()
    {
        cards = new Dictionary<long, CardList>();
        CardList list1 = new CardList();
        CardList list2 = new CardList();

        list1.Cards = new List<CardInfo>();
        list2.Cards = new List<CardInfo>();
        for (int i = 0; i < count; i++)
        {
            list1.Cards.Add(new CardInfo()
            {
                Id = 0,
                Uid = i,
            });
            list2.Cards.Add(new CardInfo()
            {
                Id = 0,
                Uid = i + count,
            });
        }
        cards.Add(role_1, list1);
        cards.Add(role_2, list2);

        cards_select = new Dictionary<long, List<CardInfo>>();
        cards_select.Add(role_1, new List<CardInfo>());
        cards_select.Add(role_2, new List<CardInfo>());

        PushRolesReady(cards);
        await Task.Delay(500);
        BeginTurn();
    }
    private void BeginTurn()
    {
        PushTurnBegin(turn);
        ServerInstance.env.BindUpdate(Update);
        time = DateTime.Now;
        start = time;
    }
    DateTime time;
    DateTime start;
    private void DropCard(long role)
    {
        var list = cards[role].Cards;
        var index = Random.Range(0, list.Count);
        var card = list[index];
        cards_select[role].Add(card);
        list.RemoveAt(index);
    }
    private void BackCard(long role)
    {
        var card = cards_select[role][turn];
        var list = cards[role].Cards;
        list.Add(card);
    }
    private void Update()
    {
        var now = DateTime.Now;
        if ((now - time).TotalSeconds < 1) return;
        {
            SPTurnTimer rsp = new SPTurnTimer();
            rsp.Second = (float)(now - start).TotalSeconds;
            foreach (var _role in roles)
            {
                NetServerHelper.SendResponse(_role, rsp);
            }
        }
        if (IsTurnEnd())
        {
            UpdateEnd();
            PushTurnResult();
            if (GetGameWinner() != -1)
            {
                PushGameResult();
            }
        }
        time = now;
    }
    private async void PushTurnResult()
    {
        await Task.Delay(500);
        SPTurnResult rsp = new SPTurnResult();
        var Info_1 = cards_select[role_1][turn];
        var Info_2 = cards_select[role_2][turn];
        var _1 = Info_1 != null;
        var _2 = Info_2 != null;
        if (_1 && _2)
        {
            var card_1 = Info_1.Id;
            var card_2 = Info_2.Id;
            rsp.Type = TurnResultType.Normal;

            bool role_1_win = card_1 < card_2;
            if (role_1_win)
            {
                rsp.RoleID = role_1;
                BackCard(role_1);
            }
            else
            {
                rsp.RoleID = role_2;
                BackCard(role_2);
            }
        }
        else if (_1 && !_2)
        {
            rsp.RoleID = role_1;
            BackCard(role_1);
            DropCard(role_2);
            rsp.Type = TurnResultType.DropOne;
        }
        else if (!_1 && _2)
        {
            rsp.RoleID = role_2;
            DropCard(role_1);
            BackCard(role_2);
            rsp.Type = TurnResultType.DropOne;

        }
        else if (!_1 && !_2)
        {
            rsp.RoleID = -1000;
            DropCard(role_1);
            DropCard(role_2);
            rsp.Type = TurnResultType.DropTwo;

        }

        rsp.Cards = new CardDic() { Cards = cards };

        foreach (var _role in roles)
        {
            NetServerHelper.SendResponse(_role, rsp);
        }
    }
    private async void PushGameResult()
    {
        await Task.Delay(1500);
        SPBattleEnd rsp = new SPBattleEnd();
        rsp.RoleID = GetGameWinner();
        rsp.Items = new ItemDic() { items = new Dictionary<long, int>() };
        rsp.Items.items.Add(1, 2);
        foreach (var _role in roles)
        {
            NetServerHelper.SendResponse(_role, rsp);
        }
        await Task.Delay(1500);
        NetServerHelper.GetPeer<ItemCountPeer>()?.PushItemsChange(rsp.RoleID, rsp.Items);
    }
    private void UpdateEnd()
    {
        ServerInstance.env.UnBindUpdate(Update);
    }

    public override void BeginNewTurn()
    {
        turn++;
        BeginTurn();
    }
}
