using LoopSever.Project.Define;
using LoopSever.ServerCore.Modules.NetCore;

namespace LoopSever.Project.Game.Define;

public enum LoginType
{
    Login, Signin
}

[NetMessageCode(ModuleDefine.Role, 1)]
public class CSRoleLogin : IRequest
{
    public LoginType loginType { get; set; }
    public string Password { get; set; }
    public long RoleID { get; set; }
}
[NetMessageCode(ModuleDefine.Role, 1)]
public class SCRoleLogin : IResponse
{
    public int Code { get; set; }
    public LoginType loginType { get; set; }
    public string Password { get; set; }
    public long RoleID { get; set; }
}
[NetworkErrCodeDefine]
public class LoginErrCode : ErrCodeDefine
{
    public static int NotExistRoleID = 2;
    public static int PasswordErr = 3;

}

