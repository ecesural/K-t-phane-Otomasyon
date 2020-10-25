using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeriParkProje.Data.Concrete.Context;
using VeriParkProje.Data.Concrete.Models;

namespace VeriParkProje.Bussines.Interfaces.CountryRepository
{
   public  class CountryRepository:ICountryRepository
    {
        public List<Country> GetCountry()
        {
            using (var db = new VeriParkDbContext())
            {
                return db.Countries.ToList();
            }
        }


    }
}
