using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeriParkProje.Data.Concrete.Models;

namespace VeriParkProje.Data.Interfaces.SpecialDayRepository
{
    interface ISpecialDayRepository
    {
        List<SpecialDay> GetSpecialDays();
    }
}
