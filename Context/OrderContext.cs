using MDK._01._01_PR_49.Model;
using Microsoft.EntityFrameworkCore;

namespace MDK._01._01_PR_49.Context
{
    public class OrderContext : DbContext
    {
        public DbSet<Orders> Orders { get; set; }

        public OrderContext()
        {
            Database.EnsureCreated();
            Orders.Load();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(Config.connection, Config.version);
        }
    }
}
