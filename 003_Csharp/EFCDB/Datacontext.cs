using Microsoft.EntityFrameworkCore;
using EFCDB.Models;
using System;

namespace EFCDB
{
    public class DataContext : DbContext
    {
        public DbSet<ConsoleModel> consoles { get; set; }
        public DbSet<GameModel> Games { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"Host=localhost;Port=5432;Database=VideoGame;Username=postgres;Password=postgres");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        static DataContext()
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }
    }
}