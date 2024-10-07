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
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(employee => employee.Id).ValueGeneratedOnAdd();
            builder.Property(employee => employee.FIO).IsRequired();

            builder.HasMany(employee => employee.Orders)
                .WithOne(order => order.Employee)
                .HasForeignKey(order => order.EmployeeId)
                .HasPrincipalKey(employee => employee.Id).OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(employee => employee.Contacts)
                .WithOne(contacts => contacts.Employee)
                .HasForeignKey(contacts => contacts.EmployeeId)
                .HasPrincipalKey(employee => employee.Id).OnDelete(DeleteBehavior.NoAction);
                

        }
    }
}
