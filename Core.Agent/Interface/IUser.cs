using Core.Lib.Model;
using System.Collections.Generic;

namespace Core.Agent.Interface
{
    public interface IUser
    {
        List<User> GetUserList();

        User GetUserByID(int id);

        bool CreateUser(User user);

        bool DeleteUser(int id);

        bool UpdateUser(User user);
    }
}
