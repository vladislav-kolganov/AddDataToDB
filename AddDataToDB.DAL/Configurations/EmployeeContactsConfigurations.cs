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
    public class EmployeeContactsConfigurations : IEntityTypeConfiguration<EmployeeContacts>
    {
        public void Configure(EntityTypeBuilder<EmployeeContacts> builder)
        {
            builder.Property(contacts => contacts.Id).ValueGeneratedOnAdd();
            builder.Property(contacts => contacts.Contact).IsRequired().HasMaxLength(100);
            builder.Property(contacts => contacts.TypeContact).IsRequired().HasMaxLength(100);

            
        }
    }
}
