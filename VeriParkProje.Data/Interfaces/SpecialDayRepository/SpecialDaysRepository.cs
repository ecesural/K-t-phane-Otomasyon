using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeriParkProje.Data.Concrete.Context;
using VeriParkProje.Data.Concrete.Models;

namespace VeriParkProje.Data.Interfaces.SpecialDayRepository
{
  public class SpecialDaysRepository
    {

        public List<SpecialDay> GetSpecialDays()
        {
            using (var db = new VeriParkDbContext())
            {
                return db.SpecialDays.ToList();
            }
        }
    }
}
