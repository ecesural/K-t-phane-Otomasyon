using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using VeriParkProje.Bussines.Concrete.Engine;
using VeriParkProje.Data.Concrete.Models;

namespace VeriParkProje.Bussines.Concrete.Methods
{
   public class Methods
    {
        private readonly SpecialDayEngine specialDayEngine = new SpecialDayEngine();
        private readonly CountryEngine countryEngine = new CountryEngine();

        public string CalculateAmount(Borrow model)
        {
            var amount = 0;
            var country = countryEngine.GetCountry().FirstOrDefault(p => p.Id == model.CountryId);
            var specialDays = specialDayEngine.GetSpecialDays().Where(p => p.CountryId == model.CountryId).ToList();

            //Öncelikle ödünç alındığı ve iade edildiği tarihler arasında kaç gün var onu hesaplıyoruz.
            double countDays = (model.BookReturned - model.BookCheckedOut).TotalDays;

            //Eğer aradaki gün farkı 10 günden küçük ise yani 10 gün içerisinde kitabı iade ediyorsa ücret vermesine gerek yoktur.
            if (countDays < 10)
            {
                return "Your Penalty Amount:" + amount + country.CurrencyCode;
            }

            //Diğer koşulumuzda ise 10 günlük ücretsiz ödünç alma süresi geçildiyse ödünç alıdığı tarihe 10 gün ekleyere iade tarih arasındaki özel günleri ve haftasonlarını bularak işleme dahil etmeden sadece çalışma günlerindeki ceza miktarı hesaplanmıştır.

            else 
            { 
            for (var date = model.BookCheckedOut.AddDays(10); model.BookReturned.CompareTo(date) > 0; date = date.AddDays(1.0))
            {
             
                var findingSpecialDays = specialDays.Where(p => p.SpecialDate.Month == date.Month && p.SpecialDate.Day == date.Day).ToList();
               
              if (findingSpecialDays.Any() || date.DayOfWeek.ToString() == country.OffDay1 || date.DayOfWeek.ToString() == country.OffDay2)
                {
                    continue;
                }
                amount += 5;
            }
            return "Your Penalty Amount:" + amount + country.CurrencyCode;
            }
        }
        public List<SelectListItem> ReturnCountriesASelectListItems(List<Country> countries)
        {
            var countryDropDownItems = new List<SelectListItem>();
            foreach (var countryItem in countries)
            {
                countryDropDownItems.Add(new SelectListItem
                {
                    Text = countryItem.CountryName,
                    Value = countryItem.Id.ToString()
                });
            }
            return countryDropDownItems;
        }

    }
}
