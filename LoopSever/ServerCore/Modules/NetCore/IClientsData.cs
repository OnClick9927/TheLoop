using IFramework.Net;
using IFramework.Packets;

namespace LoopSever.ServerCore.Modules.NetCore
{
    public interface IClientsData
    {
        void SetPkgSize(int pkgSize);
        void Accept(SocketToken sToken);
        void Disconnect(SocketToken sToken);

        PacketReader? GetPacketReader(SocketToken? sToken);
    }

}
