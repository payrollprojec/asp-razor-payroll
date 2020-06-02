using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollAppRazorPages.Models
{
    public class StaffData
    {
        public int Id { get; set; }

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


        public string ApplicationUserId { get; set; }
        [Required]
        public ApplicationUser ApplicationUser { get; set; }
    }
}
