using MDK._01._01_PR_49.Model;
using Microsoft.EntityFrameworkCore;

namespace MDK._01._01_PR_49.Context
{
    public class DishContext : DbContext
    {
        public DbSet<Dish> Dishes { get; set; }

        public DishContext()
        {
            Database.EnsureCreated();
            Dishes.Load();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(Config.connection, Config.version);
        }
    }
}
