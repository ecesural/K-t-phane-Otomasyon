using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriParkProje.Data.Concrete.Models
{
  public  class Borrow
    {
        public Borrow()
        {
            BookReturned = DateTime.Now;
            BookCheckedOut= DateTime.Now;
        }

        [Display(Name = "Book ReturnedDate")]
        [Required(ErrorMessage = "Please Enter Book Returned Date")]
        public DateTime BookReturned { get; set; }

        [Display(Name = "Book CheckedOutDate")]
        [Required(ErrorMessage = "Please Enter Book CheckedOut Date")]
        public DateTime BookCheckedOut { get; set; }

        public int CountryId { get; set; }
    }
}
