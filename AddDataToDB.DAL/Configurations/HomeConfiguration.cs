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
    public class HomeConfiguration : IEntityTypeConfiguration<Home>
    {
        public void Configure(EntityTypeBuilder<Home> builder)
        {
            builder.Property(home => home.Id).ValueGeneratedOnAdd();
            builder.Property(street => street.NumberHome).IsRequired().HasDefaultValue(10);
            builder.Property(street => street.NumberApartament).IsRequired().HasDefaultValue(10);

        }
    }
}
