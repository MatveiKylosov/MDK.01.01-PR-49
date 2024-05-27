using MDK._01._01_PR_49.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace MDK._01._01_PR_49.Context
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public UserContext()
        {
            Database.EnsureCreated();
            Users.Load();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(Config.connection, Config.version);
        }
    }
}
