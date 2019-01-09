using Core.Agent.Interface;
using Core.Lib;
using Core.Lib.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Agent.Service
{
    public class Sys_UserService : ISys_User
    {
        private DBcontext dBcontext;
        public Sys_UserService(DBcontext _dBcontext)
        {
            this.dBcontext = _dBcontext;
        }

        public bool CreateSysUser(Sys_User user)
        {
            dBcontext.Sys_User.Add(user);
            if (dBcontext.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteSysUser(int id)
        {
            var sysUser = dBcontext.Sys_User.Where(x => x.PKID == id).FirstOrDefault();
            if (sysUser == null)
            {
                return false;
            }
            dBcontext.Sys_User.Remove(sysUser);
            if (dBcontext.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Sys_User GetSysUserByID(int id)
        {
            var sysUser = dBcontext.Sys_User.Where(x => x.PKID == id).FirstOrDefault();
            if (sysUser == null)
            {
                return new Sys_User();
            }
            else
            {
                return sysUser;
            }
        }

        public List<Sys_User> GetSysUserList()
        {
            return dBcontext.Sys_User.ToList();
        }

        public bool UpdateSysUser(Sys_User sysUser)
        {
            var updateSysUser = dBcontext.Sys_User.Where(x => x.PKID == sysUser.PKID).FirstOrDefault();
            if (updateSysUser == null)
            {
                return false;
            }
            dBcontext.Sys_User.Update(updateSysUser);
            if (dBcontext.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
