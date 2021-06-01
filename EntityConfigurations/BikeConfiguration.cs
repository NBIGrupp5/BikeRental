using BikeRental.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace BikeRental.EntityConfigurations
{
    public class BikeConfiguration : IEntityTypeConfiguration<Bike>
    {
        public void Configure(EntityTypeBuilder<Bike> builder)
        {
            builder
                .HasKey(x => x.BikeId);

            builder
                .Property(x => x.BikeId)
                .UseIdentityColumn(1, 1);

            builder
                .Property(x => x.FrameNumber);

            builder
                .Property(b => b.BikeTypeName);
        }
    }
}
