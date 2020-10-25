using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeriParkProje.Bussines.Interfaces;
using VeriParkProje.Bussines.Interfaces.CountryRepository;
using VeriParkProje.Data.Concrete.Models;

namespace VeriParkProje.Bussines.Concrete.Engine
{
  public  class CountryEngine:ICountryService
    {
      
        private readonly CountryRepository _countryRepository = new CountryRepository();

        public List<Country> GetCountry()
        {
            return _countryRepository.GetCountry();
        }
    }
}
