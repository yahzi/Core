using System;
using System.Collections.Generic;
using System.Text;
using Core.Lib.Interface;
using Core.Lib.Model;
using Core.Lib.Service;
namespace Core.Lib.Agent
{
    public class AgentUser : I_User
    {
        UserService userService = new UserService();
        public bool CreateUser(User user)
        {
            return userService.CreateUser(user);
        }

        public bool DeleteUser(int id)
        {
            return userService.DeleteUser(id);
        }

        public User GetUserByID(int id)
        {
            return userService.GetUserByID(id);
        }

        public List<User> GetUserList()
        {
            return userService.GetUserList();
        }

        public bool UpdateUser(User user)
        {
            return userService.UpdateUser(user);
        }
    }
}
