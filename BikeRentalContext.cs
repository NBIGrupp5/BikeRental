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
                    new BikeType
                    {
                        BikeTypeName = "Elcykel", Id = 1, BikeTypePrice = 399, BikeTypeDescription = "Passar bra vid längre sträckor eller om du vill ha lite extra hjälp i uppförsbackarna. Elmotorn hjälper dig upp till 25km/h.", 
                        BikeTypeImage = "https://s3-eu-west-1.amazonaws.com/static.wm3.se/sites/531/media/219863_medium_161179_medium_cykel1_%281%29.png"
                    }
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
