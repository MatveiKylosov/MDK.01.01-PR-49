﻿using MDK._01._01_PR_49.Model;
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
            optionsBuilder.UseMySql(Config.connection, Config.version);
        }
    }
}
