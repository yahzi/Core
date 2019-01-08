using Core.Lib.Model;
using Microsoft.EntityFrameworkCore;

namespace Core.Lib
{
    public class DBcontext : DbContext
    {
        public DBcontext(DbContextOptions<DBcontext> options) : base(options)
        {
        }

        public DbSet<User> User { get; set; }
    }
}
