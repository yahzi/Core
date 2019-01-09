using Core.Agent.Interface;
using Core.Lib;
using Core.Lib.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Agent.Service
{
    public class UserService : IUser
    {
        private DBcontext dBcontext;
        public UserService(DBcontext _dBcontext)
        {
            this.dBcontext = _dBcontext;
        }

        public bool CreateUser(User user)
        {
            dBcontext.User.Add(user);
            if (dBcontext.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteUser(int id)
        {
            var user = dBcontext.User.Where(x=>x.PKID == id).FirstOrDefault();
            if (user == null)
            {
                return false;
            }
            dBcontext.User.Remove(user);
            if (dBcontext.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public User GetUserByID(int id)
        {
            var user = dBcontext.User.Where(x => x.PKID == id).FirstOrDefault();
            if (user == null)
            {
                return new User();
            }
            else
            {
                return user;
            }
        }

        public List<User> GetUserList()
        {
            return dBcontext.User.ToList();
        }

        public bool UpdateUser(User user)
        {
            var updateUser = dBcontext.User.Where(x => x.PKID == user.PKID).FirstOrDefault();
            if (updateUser == null)
            {
                return false;
            }
            dBcontext.User.Update(updateUser);
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
