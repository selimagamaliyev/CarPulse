using CarPulse.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPulse.Infrastructure.Context
{
    public class CarContext : DbContext
    {
        public CarContext(DbContextOptions<CarContext> options) : base(options)
        {

        }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Supply> Supplies { get; set; }
        public DbSet<Engine> Engines { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<Mileage> Mileages { get; set; }
        public DbSet<Salesman> Salesmen { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Announcement ile Car arasındaki 1:1 elaqe
            modelBuilder.Entity<Announcement>()
                .HasOne(ı => ı.Car)
                .WithOne(a => a.Announcement)
                .HasForeignKey<Announcement>(a => a.CarID);

            // Announcement ile Salesman arasındaki 1:N elaqe
            modelBuilder.Entity<Announcement>()
                .HasOne(ı => ı.Salesman)
                .WithMany(s => s.Announcements)
                .HasForeignKey(ı => ı.SalesmanID);

            // Car ile Supply arasındaki 1:N elaqe
            modelBuilder.Entity<Car>()
                .HasMany(a => a.Supplies)
                .WithOne(s => s.Car)
                .HasForeignKey(s => s.CarID);

            // Car ile Photo arasındaki 1:N elaqe
            modelBuilder.Entity<Car>()
                .HasMany(a => a.Photos)
                .WithOne(p => p.Car)
                .HasForeignKey(p => p.CarID);

            // Car ile Price arasındaki 1:1 elaqe
            modelBuilder.Entity<Car>()
                .HasOne(a => a.Price)
                .WithOne(p => p.Car)
                .HasForeignKey<Price>(p => p.CarID);

            // Car ile Mileage arasındaki 1:1 elaqe
            modelBuilder.Entity<Car>()
                .HasOne(a => a.Mileage)
                .WithOne(m => m.Car)
                .HasForeignKey<Mileage>(m => m.CarID);

            // Car ile Engine arasındaki 1:1 elaqe
            modelBuilder.Entity<Car>()
                .HasOne(a => a.Engine)
                .WithOne(e => e.Car)
                .HasForeignKey<Engine>(e => e.CarID);
        }
    }    
}
