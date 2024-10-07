using AddDataToDB.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddDataToDB.DAL.Entity
{
    public class Country : IEntityId <long>
    {
        public long Id { get; set; }
        public string CountryName { get; set; }
        public List<City> Cities { get; set; }
    }
}
