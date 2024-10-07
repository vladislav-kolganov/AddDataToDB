using AddDataToDB.DAL.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddDataToDB.DAL.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration <User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(user => user.Id).ValueGeneratedOnAdd();
            builder.Property(user => user.FIO).IsRequired().HasMaxLength(400); 
            builder.Property(user => user.Email).IsRequired().HasMaxLength(200);
            builder.HasMany(user => user.Orders).WithOne(order => order.User)
            .HasForeignKey(report => report.UserId)
            .HasPrincipalKey(user => user.Id).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
