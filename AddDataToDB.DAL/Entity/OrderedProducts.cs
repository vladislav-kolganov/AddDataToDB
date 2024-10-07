using AddDataToDB.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddDataToDB.DAL.Entity
{
    public class OrderedProducts: IEntityId<long>
    {
        public long Id { get; set; }
        public long OrderId { get; set; }
        public long ProductId { get; set; }
        public int Count { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
        
    }
}
