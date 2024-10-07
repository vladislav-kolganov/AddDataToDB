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
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(product => product.Id).ValueGeneratedOnAdd();
            builder.Property(product => product.Name).IsRequired().HasMaxLength(500);
            builder.Property(product => product.Description).IsRequired(false).HasMaxLength(2000);
            builder.Property(product => product.Price).IsRequired();
            builder.Property(product => product.SupplierId).IsRequired(false);
            builder.Property(product => product.Count).IsRequired().HasDefaultValue(100);
        
      
            builder.HasMany(product => product.Ordereds)
                .WithOne(ordered => ordered.Product)
            .HasForeignKey(ordered => ordered.ProductId)
            .HasPrincipalKey(product => product.Id).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
