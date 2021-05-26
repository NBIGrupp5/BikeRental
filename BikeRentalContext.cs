using BikeRental.EntityConfigurations;
using BikeRental.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeRental
{
    public class BikeRentalContext : DbContext
    {
        public BikeRentalContext(DbContextOptions<BikeRentalContext> options) : base(options)
        { }

        public DbSet<Bike> Bikes { get; set; }
        public DbSet<Bike> BikeTypes { get; set; }
        public DbSet<Bike> Bookings { get; set; }
        public DbSet<Bike> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .ApplyConfiguration(new BikeConfiguration())
                .ApplyConfiguration(new BikeTypeConfiguration())
                .ApplyConfiguration(new BookingConfiguration())
                .ApplyConfiguration(new CustomerConfiguration());

            base.OnModelCreating(modelBuilder);
        }

    }
}
