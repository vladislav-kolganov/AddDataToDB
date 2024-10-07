using AddDataToDB.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddDataToDB.DAL.Entity
{
    public class Home: IEntityId <long>
    {
        public long Id { get; set; }
        public string NumberHome { get; set; }
        public string NumberApartament { get; set; }
        public long StreetId { get; set; }
        public Street Street { get; set; }
        public Order Order { get; set; }
        public Supplier Supplier { get; set; } 
    }
}
