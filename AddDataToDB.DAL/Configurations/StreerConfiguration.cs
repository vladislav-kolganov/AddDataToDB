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
    public class StreerConfiguration : IEntityTypeConfiguration<Street>
    {
        public void Configure(EntityTypeBuilder<Street> builder)
        {
            builder.Property(street => street.Id).ValueGeneratedOnAdd();
            builder.Property(street => street.StreetName).IsRequired().HasMaxLength(200);
   
            builder.HasMany(street => street.Homes).WithOne(home => home.Street)
            .HasForeignKey(home => home.StreetId)
            .HasPrincipalKey(street => street.Id).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
