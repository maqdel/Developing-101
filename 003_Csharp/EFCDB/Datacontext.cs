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
            var createdIn = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            var updatedIn = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc);

            modelBuilder.Entity<BrandModel>().HasData(
                new BrandModel { Id = 1, Name = "Sony", Description = "Japanese multinational conglomerate corporation", Enabled = true, CreatedIn = createdIn, UpdatedIn = updatedIn },
                new BrandModel { Id = 2, Name = "Microsoft", Description = "American multinational technology company", Enabled = true, CreatedIn = createdIn, UpdatedIn = updatedIn },
                new BrandModel { Id = 3, Name = "Nintendo", Description = "Japanese multinational consumer electronics and video game company", Enabled = true, CreatedIn = createdIn, UpdatedIn = updatedIn }
            );

            modelBuilder.Entity<ConsoleModel>().HasData(
                new ConsoleModel { Id = 1, Name = "PlayStation 5", Description = "", BrandId = 1, Enabled = true, CreatedIn = createdIn, UpdatedIn = updatedIn },
                new ConsoleModel { Id = 2, Name = "Xbox Series X", Description = "", BrandId = 2, Enabled = true, CreatedIn = createdIn, UpdatedIn = updatedIn },
                new ConsoleModel { Id = 3, Name = "Nintendo Switch", Description = "", BrandId = 3, Enabled = true, CreatedIn = createdIn, UpdatedIn = updatedIn }
            );

            modelBuilder.Entity<GameModel>().HasData(
                new GameModel { Id = 1, Name = "Demon's Souls", Description = "", ConsoleId = 1, Enabled = true, CreatedIn = createdIn, UpdatedIn = updatedIn },
                new GameModel { Id = 2, Name = "Halo Infinite", Description = "", ConsoleId = 2, Enabled = true, CreatedIn = createdIn, UpdatedIn = updatedIn },
                new GameModel { Id = 3, Name = "The Legend of Zelda: Breath of the Wild", Description = "", ConsoleId = 3, Enabled = true, CreatedIn = createdIn, UpdatedIn = updatedIn }
            );
        }
        static DataContext()
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }
    }
}