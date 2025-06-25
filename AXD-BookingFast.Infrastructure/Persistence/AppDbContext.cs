using AXD_BookingFast.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AXD_BookingFast.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<RoomRate> RoomRates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Relaciones básicas y restricciones:
            modelBuilder.Entity<Hotel>()
                .HasMany(h => h.Rooms)
                .WithOne(r => r.Hotel)
                .HasForeignKey(r => r.HotelId);

            modelBuilder.Entity<Room>()
                .HasMany(r => r.Reservations)
                .WithOne(res => res.Room)
                .HasForeignKey(res => res.RoomId);

            // Enums como int
            modelBuilder.Entity<Room>()
                .Property(r => r.RoomType)
                .HasConversion<int>();

            modelBuilder.Entity<RoomRate>()
                .Property(r => r.RoomType)
                .HasConversion<int>();

            modelBuilder.Entity<RoomRate>()
                .Property(r => r.SeasonType)
                .HasConversion<int>();

            modelBuilder.Entity<Season>()
                .Property(s => s.SeasonType)
                .HasConversion<int>();

            //SeedData: Datos iniciales para pruebas:
            SeedData.Seed(modelBuilder);
        }
    }
}
