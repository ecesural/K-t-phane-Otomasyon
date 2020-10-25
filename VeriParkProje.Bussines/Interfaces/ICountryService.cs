using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeriParkProje.Data.Concrete.Models;

namespace VeriParkProje.Bussines.Interfaces
{
    interface ICountryService
    {
        List<Country> GetCountry();
    }
}
