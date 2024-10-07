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
    public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.Property(supplier => supplier.Id).ValueGeneratedOnAdd();
            builder.Property(supplier => supplier.Title).HasMaxLength(400);


            builder.HasOne(supplier => supplier.Home).WithOne(home => home.Supplier)
                .HasForeignKey<Supplier>(supplier => supplier.Addres)
                .HasPrincipalKey<Home>(home => home.Id).OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(supplier => supplier.Products).WithOne(product => product.Supplier)
            .HasForeignKey(product => product.SupplierId)
            .HasPrincipalKey(supplier => supplier.Id).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
