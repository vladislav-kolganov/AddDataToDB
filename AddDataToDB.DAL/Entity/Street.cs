using AddDataToDB.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddDataToDB.DAL.Entity
{
    public class Street: IEntityId <long>
    {
        public long Id { get; set; }
        public string StreetName { get; set; }    
        public long CityId { get; set; }
        public City City { get; set; }
        public List<Home> Homes { get; set; }
    }
}
