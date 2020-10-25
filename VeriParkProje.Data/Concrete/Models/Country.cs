using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriParkProje.Data.Concrete.Models
{

    [Serializable]
    [Table("Country")]
    public class Country
    {   
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Country Name")]
        [Display(Name = "Country Name")]
        public string CountryName { get; set; }

        [Required(ErrorMessage = "Please Enter Currency Code")]
        [Display(Name = "Currency Code")]
        public string CurrencyCode { get; set; }

        [Required(ErrorMessage = "Please Enter Penalty Amount")]
        [Display(Name = "Penalty Amount")]
        public decimal PenaltyAmount { get; set; }

        [Display(Name = "Off Day 1")]
        public string OffDay1 { get; set; }

        [Display(Name = "Off Day 2")]
        public string OffDay2 { get; set; }
    }
}
