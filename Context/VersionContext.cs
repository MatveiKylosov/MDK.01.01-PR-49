using MDK._01._01_PR_49.Model;
using Microsoft.EntityFrameworkCore;

namespace MDK._01._01_PR_49.Context
{
    public class VersionContext : DbContext
    {
        public DbSet<Version> Versions { get; set; }

        public VersionContext()
        {
            Database.EnsureCreated();
            Versions.Load();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=127.0.0.1; uid=ISP_21_2_10;pwd=DSFV988Np#;database=ISP_21_2_10", new MySqlServerVersion(new System.Version(8, 0, 11)));
        }
    }
}
