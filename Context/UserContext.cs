using MDK._01._01_PR_49.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace MDK._01._01_PR_49.Context
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public UsersContext()
        {
            Database.EnsureCreated();
            Users.Load();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=127.0.0.1; uid=ISP_21_2_10;pwd=DSFV988Np#;database=ISP_21_2_10", new MySqlServerVersion(new Version(8, 0, 11)));
        }
    }
}
