using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollAppRazorPages.Models
{
    public class ApplicationUser : IdentityUser
    {
        // User's personal details
        [Display(Name = "Name")]
        public string FullName { get; set; }

        [Display(Name = "I/C No")]
        public string ICNo { get; set; }


        // Staff extra details
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime? DOB { get; set; }

        [Display(Name = "Date Joined")]
        [DataType(DataType.Date)]
        public DateTime? DateJoined { get; set; }

        [Display(Name = "Tax No")]
        public string TaxNo { get; set; }

        [Display(Name = "EPF No")]
        public string EPFNo { get; set; }

        [Display(Name = "SOCSO No")]
        public string SocsoNo { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Basic Salary")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? BasicSalary { get; set; }

        public List<Attendance> Attendances { get; set; }
    }
}
