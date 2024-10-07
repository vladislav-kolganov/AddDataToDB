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
    public class CountryConfigurations : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.Property(country => country.Id).ValueGeneratedOnAdd();
            builder.Property(country => country.CountryName).IsRequired().HasMaxLength(200);
          
            builder.HasMany(country => country.Cities)
                .WithOne(city => city.Country)
            .HasForeignKey(city => city.CountryId)
            .HasPrincipalKey(country => country.Id).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
