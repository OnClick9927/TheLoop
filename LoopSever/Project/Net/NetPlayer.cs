using LoopSever.ServerCore.Modules.NetCore;
using IFramework.Net;

namespace LoopSever.Project.Net;

public class NetPlayer : ClientData
{
    public long id = 0; //roleId
    [Newtonsoft.Json.JsonIgnore] public SocketToken token; //链接token
}