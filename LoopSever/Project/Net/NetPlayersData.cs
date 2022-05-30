using LoopSever.Project.Game;
using LoopSever.ServerCore.Modules.NetCore;
using IFramework;
using IFramework.Net;

namespace LoopSever.Project.Net;

public class ClientStatusEvent : IEventArgs
{
    public ClientStatusEventType type;
    public long roleId;
    public SocketToken token;
}

public enum ClientStatusEventType
{
    Connect,
    Disconnect,
    RoleLogin,
}

public class NetPlayersData : ClientsData<NetPlayer>
{
    private Dictionary<long, SocketToken?> mapRoleId = new Dictionary<long, SocketToken?>();
    
    public void BindSTokenWithRole(long roleId, SocketToken sToken)
    {
        mapRoleId[roleId] = sToken;
    }

    public void UnBindSTokenWithRole(long roleId)
    {
        mapRoleId[roleId] = null;
        mapRoleId.Remove(roleId);
    }

    public SocketToken? GetSTokenByRoleId(long roleId)
    {
        SocketToken? t;
        if (mapRoleId.TryGetValue(roleId, out t))
        {
            return t;
        }

        return null;
    }
    
    public long GetRoleIdBySToken(SocketToken sToken)
    {
        var data = GetData(sToken);
        if (data != null)
        {
            return data.id;
        }
        return 0;
    }
    
    
    protected override void OnAccept(SocketToken sToken)
    {
        base.OnAccept(sToken);
        ServerInstance.env.modules.Message.Publish(this, new ClientStatusEvent()
        {
            token = sToken,
            roleId = 0,
            type = ClientStatusEventType.Connect,
        }, IFramework.Modules.Message.MessageUrgencyType.Immediately);
    }

    protected override void OnDisconnect(SocketToken sToken)
    {
        var data = GetData(sToken);
        base.OnDisconnect(sToken);
        ServerInstance.env.modules.Message.Publish(this, new ClientStatusEvent()
        {
            token = sToken,
            roleId = data.id,
            type = ClientStatusEventType.Disconnect,
        }, IFramework.Modules.Message.MessageUrgencyType.Immediately);
        if (data != null&& data.id!=0)
        {
            UnBindSTokenWithRole(data.id);
        }
    }
    
    public void OnRoleLogIn(long roleId, SocketToken token)
    {
        var data = GetData(token);
        if (data != null)
        {
            data.token = token;
            data.id = roleId;
        }
        BindSTokenWithRole(roleId,token);
        ServerInstance.env.modules.Message.Publish(this, new ClientStatusEvent()
        {
            token = token,
            roleId = data.id,
            type = ClientStatusEventType.RoleLogin,
        }, IFramework.Modules.Message.MessageUrgencyType.Immediately);
    }
    
    

}