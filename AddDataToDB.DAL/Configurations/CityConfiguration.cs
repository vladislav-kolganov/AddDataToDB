using AddDataToDB.DAL.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddDataToDB.DAL.Configurations
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.Property(city => city.Id).ValueGeneratedOnAdd();
            builder.Property(city => city.Name).IsRequired().HasMaxLength(500);
           


            builder.HasMany(city => city.Streets)
                .WithOne(street => street.City)
            .HasForeignKey(street => street.CityId)
            .HasPrincipalKey(city => city.Id);
        }
    }
}
