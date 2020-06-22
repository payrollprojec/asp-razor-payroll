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

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Holiday Date")]
        [DataType(DataType.Date)]
        public DateTime? HolidayDate { get; set; }

        [Display(Name = "Holiday Description")]
        public string HolidayDes { get; set; }
    }
}
