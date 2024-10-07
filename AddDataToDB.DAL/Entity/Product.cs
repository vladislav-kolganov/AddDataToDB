using AddDataToDB.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddDataToDB.DAL.Entity
{
    public class Product: IEntityId <long>
    {
        public long Id { get; set; }
        public string Name { get; set; }    
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int? Count { get; set; }
        public long? SupplierId { get; set; }
        public Supplier Supplier { get; set; }
       public List<OrderedProducts> Ordereds { get; set; }

    }
}
