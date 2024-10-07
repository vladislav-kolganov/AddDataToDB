using AddDataToDB.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddDataToDB.DAL.Entity
{
    public class Employee : IEntityId<long>
    {
        public long Id { get; set; }
        public string FIO { get; set; }
        public List<Order> Orders { get; set; }
        public List<EmployeeContacts> Contacts { get; set; }

    }
}
