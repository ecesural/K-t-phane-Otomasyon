using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeriParkProje.Bussines.Interfaces;
using VeriParkProje.Data.Concrete.Models;
using VeriParkProje.Data.Interfaces.SpecialDayRepository;

namespace VeriParkProje.Bussines.Concrete.Engine
{
    public class SpecialDayEngine : ISpecialDayService
    {
        private readonly SpecialDaysRepository specialDaysRepository = new SpecialDaysRepository();
        public List<SpecialDay> GetSpecialDays()
        {
            return specialDaysRepository.GetSpecialDays();
        }
    }
}
