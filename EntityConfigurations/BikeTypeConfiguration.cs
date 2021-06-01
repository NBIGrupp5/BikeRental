using BikeRental.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace BikeRental.EntityConfigurations
{
    public class BikeTypeConfiguration : IEntityTypeConfiguration<BikeType>
    {
        public void Configure(EntityTypeBuilder<BikeType> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .UseIdentityColumn(1, 1);

            builder
                .Property(x => x.CreatedAt)
                .HasDefaultValue(DateTime.Now);

            builder
                .Property(x => x.BikeTypeName);

            builder
                .Property(x => x.BikeTypePrice);
        }
    }
}
