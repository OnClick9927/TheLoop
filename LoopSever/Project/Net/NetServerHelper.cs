using LoopSever.Project.Game;
using LoopSever.ServerCore.Modules.NetCore;
using IFramework.Net;

namespace LoopSever.Project.Net;

public static class NetServerHelper
{
    private static TcpSever? _server;

    public static TcpSever Server
    {
        get
        {
            if (_server == null)
            {
                _server = ServerInstance.GetServer();
            }

            return _server;
        }
    }

    public static PeerT? GetPeer<PeerT>() where PeerT : class
    {
        return ServerInstance.GetServer().PeerPool.GetHandlePeer<PeerT>();
    }

    public static void SendResponse<TResponse>(SocketToken token, TResponse response) where TResponse : IResponse
    {
        Server.SendResponse<TResponse>(token, response);
    }

    public static void SendResponse<TResponse>(long roleId, TResponse response) where TResponse : IResponse
    {
        var clientsData = Server.GetClientsData<NetPlayersData>();
        var token = clientsData.GetSTokenByRoleId(roleId);
        if (token != null)
        {
            SendResponse(token, response);
        }
    }
}