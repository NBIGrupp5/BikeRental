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
                        BikeTypeName = "Elcykel", Id = 1, BikeTypePrice = 299, BikeTypeDescription = "Passar bra vid längre sträckor eller om du vill ha lite extra hjälp i uppförsbackarna. Elmotorn hjälper dig upp till 25km/h.", 
                        BikeTypeImage = "https://www.electricbike.com/wp-content/uploads/2020/08/Celebrity3.jpg"
                    },
                    new BikeType
                    {
                        BikeTypeName = "Stadscykel",
                        Id = 2,
                        BikeTypePrice = 249,
                        BikeTypeDescription = "Elegant kvalitetscykel. Ram med lågt insteg.",
                        BikeTypeImage = "https://images.unsplash.com/flagged/photo-1561273560-469573e7e290?ixid=MnwxMjA3fDB8MHxzZWFyY2h8OTZ8fGJpa2UlMjByaWRpbmd8ZW58MHx8MHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=60"
                    },
                    new BikeType
                    {
                        BikeTypeName = "Mountainbike",
                        Id = 3,
                        BikeTypePrice = 269,
                        BikeTypeDescription = "Vill du köra i lite tuffare terräng eller off-road passar denna cykel perfekt.",
                        BikeTypeImage = "https://images.unsplash.com/photo-1588935365434-fa1578152e18?ixid=MnwxMjA3fDB8MHxzZWFyY2h8MjR8fG1vdW50YWluJTIwYmlrZXxlbnwwfHwwfHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=60"
                    },
                    new BikeType
                    {
                        BikeTypeName = "Barncykel",
                        Id = 4,
                        BikeTypePrice = 179,
                        BikeTypeDescription = "Klart att barnen ska med cykellturen. Vi har barncyklar.",
                        BikeTypeImage = "https://image.freepik.com/free-photo/back-view-little-child-blue-coat-riding-bicycle_85672-2742.jpg"
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
