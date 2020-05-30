using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollAppRazorPages.Models
{
    public class Attendance
    {
        public int Id { get; set; }

        [Display(Name = "Staff ID")]
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime? PunchDate { get; set; }

        public int AttendanceStatusId { get; set; }
        [Display(Name = "Status")]
        public AttendanceStatus AttendanceStatus { get; set; }
    }
}
