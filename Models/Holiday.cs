using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollAppRazorPages.Models
{
    public class Holiday
    {
        public int Id { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Holiday Date")]
        [DataType(DataType.Date)]
        public DateTime? HolidayDate { get; set; }

        [Required]
        [Display(Name = "Holiday Description")]
        [StringLength(255, MinimumLength = 3)]
        public string HolidayDes { get; set; }
    }
}
