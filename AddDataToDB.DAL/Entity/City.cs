using AddDataToDB.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddDataToDB.DAL.Entity
{
    public class City : IEntityId <long>
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long CountryId { get; set; }
        public Country Country { get; set; }
        public List<Street> Streets { get; set; }
    }
}
