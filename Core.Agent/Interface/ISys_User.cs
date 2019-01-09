using Core.Lib.Model;
using System.Collections.Generic;

namespace Core.Agent.Interface
{
    public interface ISys_User
    {
        List<Sys_User> GetSysUserList();

        Sys_User GetSysUserByID(int id);

        bool CreateSysUser(Sys_User user);

        bool DeleteSysUser(int id);

        bool UpdateSysUser(Sys_User user);
    }
}
