using Microsoft.EntityFrameworkCore;
using MonitoringEF.Models;
using System.IO;

namespace MonitoringEF.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<EquipmentUsage> EquipmentUsages { get; set; }
        public DbSet<Consumable> Consumables { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Указываем путь к базе данных SQLite в папке проекта
            var dbPath = Path.Combine(Directory.GetCurrentDirectory(), "MonitoringEF.db");
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Настройка связей между таблицами
            modelBuilder.Entity<EquipmentUsage>()
            .HasOne(e => e.Equipment)
            .WithMany(e => e.EquipmentUsages)
            .HasForeignKey(e => e.EquipmentId);

            modelBuilder.Entity<EquipmentUsage>()
                .HasOne(e => e.FertilizerType)
                .WithMany(c => c.EquipmentUsagesAsFertilizer)
                .HasForeignKey(e => e.FertilizerTypeId);

            modelBuilder.Entity<EquipmentUsage>()
                .HasOne(e => e.FuelType)
                .WithMany(c => c.EquipmentUsagesAsFuel)
                .HasForeignKey(e => e.FuelTypeId);
        }

        public void EnsureDatabaseCreated()
        {
            // Автоматически создает базу данных, если она не существует            
            Database.EnsureCreated();
            DbSeeder.SeedDatabase(this);
        }
    }
}
