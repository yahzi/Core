using Core.Lib.Model;
using System.Collections.Generic;

namespace Core.Lib.Interface
{
    interface I_User
    {
        List<User> GetUserList();

        User GetUserByID(int id);

        bool CreateUser(User user);

        bool DeleteUser(int id);

        bool UpdateUser(User user);
    }
}
