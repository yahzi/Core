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
        public DbSet<Sys_User> Sys_User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Sys_User>().ToTable("Sys_User");
        }
    }
}
