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
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(order => order.Id).ValueGeneratedOnAdd();
            builder.Property(order => order.UserId).IsRequired();
            builder.Property(order => order.Date).IsRequired();
            builder.Property(order => order.Price).IsRequired();
            builder.Property(order => order.Address).IsRequired(false);
            builder.Property(order => order.EmployeeId).IsRequired(false);
            builder.Property(order => order.Status).HasDefaultValue(true);

            builder.HasOne(order => order.Home)
                .WithOne(home => home.Order)
                .HasForeignKey<Order>(order => order.Address)
                .HasPrincipalKey<Home>(home => home.Id).OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(order => order.OrderedProducts)
                .WithOne(ordered => ordered.Order)
                .HasForeignKey(ordered => ordered.OrderId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
