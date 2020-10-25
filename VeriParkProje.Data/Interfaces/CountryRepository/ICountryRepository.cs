using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeriParkProje.Data.Concrete.Models;

namespace VeriParkProje.Bussines.Interfaces.CountryRepository
{
    interface ICountryRepository
    {
        List<Country> GetCountry();
    }
}
