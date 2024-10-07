using AddDataToDB.DAL.Interfaces;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddDataToDB.DAL.Entity
{
    public class Order : IEntityId<long>
    {
        public long Id { get; set ; }
        public long UserId { get; set ; }
        public DateOnly Date { get; set ; }
        public decimal Price { get; set ; }
        public bool Status { get; set ; }
        public long? Address { get; set; }
        public long? EmployeeId { get; set ; }
        public Home Home { get; set; }
        public User User { get; set ; }
        public Employee Employee { get; set ; }
        public List<OrderedProducts> OrderedProducts { get; set ; }


    }
}
