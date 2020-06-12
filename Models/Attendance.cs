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

        public string ApplicationUserId { get; set; }

        [Required]
        public ApplicationUser ApplicationUser { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime? PunchDate { get; set; }

        public int AttendanceStatusId { get; set; }
        public AttendanceStatus AttendanceStatus{ get; set; }
    }
}
