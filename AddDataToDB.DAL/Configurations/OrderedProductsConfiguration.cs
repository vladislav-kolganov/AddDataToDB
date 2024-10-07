using AddDataToDB.DAL.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AddDataToDB.DAL.Configurations
{
    public class OrderedProductsConfiguration : IEntityTypeConfiguration<OrderedProducts>
    {
        public void Configure(EntityTypeBuilder<OrderedProducts> builder)
        {
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Count).IsRequired().HasDefaultValue(10);
        }
    }
}
