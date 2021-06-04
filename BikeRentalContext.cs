using BikeRental.EntityConfigurations;
using BikeRental.Models;
using Microsoft.EntityFrameworkCore;

namespace BikeRental
{
    public class BikeRentalContext : DbContext
    {
        public BikeRentalContext(DbContextOptions<BikeRentalContext> options) : base(options)
        { }

        public DbSet<Bike> Bikes { get; set; }
        public DbSet<BikeType> BikeTypes { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<BikeType>()
                .HasData(
                    new BikeType { BikeTypeName = "Elcykel", Id = 1, BikeTypePrice = 399 }
                );

            modelBuilder
                .Entity<Bike>()
                .HasData(
                    new Bike { FrameNumber = "1234", BikeTypeId = 1, BikeId = 1 }
                );

            modelBuilder
                .ApplyConfiguration(new BikeConfiguration())
                .ApplyConfiguration(new BikeTypeConfiguration())
                .ApplyConfiguration(new BookingConfiguration())
                .ApplyConfiguration(new CustomerConfiguration());

            base.OnModelCreating(modelBuilder);
        }

    }
}
