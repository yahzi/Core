using Microsoft.EntityFrameworkCore;
using Core.Lib.Model;

namespace Core.Lib
{
    public class DBcontext :DbContext
    {
        public DBcontext()
        {
        }

        DbSet<User> User;
    }
}
