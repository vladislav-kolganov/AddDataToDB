using AddDataToDB.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddDataToDB.DAL.Entity
{
    public class EmployeeContacts: IEntityId <long>
    {
        public long Id { get; set; }
        public long EmployeeId { get; set; }
        public string Contact { get; set; }
        public string TypeContact { get; set; }
        public Employee Employee { get; set; }
    }
}
