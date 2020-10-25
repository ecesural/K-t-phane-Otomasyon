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
    [Table("SpecialDay")]
    public class SpecialDay
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Country")]
        public int CountryId { get; set; }

        [Display(Name = "Special Date")]
        [Required(ErrorMessage = "Please Enter Special Date")]
        public DateTime SpecialDate { get; set; }
    }
}
