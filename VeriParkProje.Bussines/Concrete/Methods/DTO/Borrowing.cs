using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriParkProje.Data.Concrete.Models
{
  public  class Borrowing
    {
        public Borrowing()
        {
            BookCheckIn = DateTime.Now;
            BookReceived = DateTime.Now;
        }

        [Display(Name = "Book Give Back Date")]
        [Required(ErrorMessage = "Please Enter Book Give Back Date")]
        public DateTime BookCheckIn { get; set; }

        [Display(Name = "Book Received")]
        [Required(ErrorMessage = "Please Enter Book Received Date")]
        public DateTime BookReceived { get; set; }

        public int CountryId { get; set; }
    }
}
