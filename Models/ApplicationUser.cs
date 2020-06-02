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



        public StaffData StaffData { get; set; }
        public List<Attendance> Attendances { get; set; }
    }
}
