using AddDataToDB.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddDataToDB.DAL.Entity
{
    public class Supplier: IEntityId <long>
    {
        public long Id { get; set; }
        public string Title { get; set; } 
        public long Addres { get; set; } 
        public List<Product> Products { get; set; }
        public Home Home { get; set; }
    }
}
