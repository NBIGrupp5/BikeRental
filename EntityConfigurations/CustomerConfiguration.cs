using BikeRental.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace BikeRental.EntityConfigurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder
                .HasKey(x => x.CustomerId);

            builder
                .Property(x => x.CustomerId)
                .UseIdentityColumn(1, 1);

            builder
                .Property(x => x.FirstName);

            builder
                .Property(x => x.LastName);

            builder
                .Property(x => x.Email);

            builder
                .Property(x => x.PhoneNumber);
        }
    }
}
