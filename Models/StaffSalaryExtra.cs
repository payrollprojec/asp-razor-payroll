using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PayrollAppRazorPages.Models
{
    public class StaffSalaryExtra
    {
        public int Id { get; set; }

        [Required]
        public int StaffSalaryId{ get; set; }
        public StaffSalary StaffSalary { get; set; }
        
        public int SalaryItemId { get; set; }
        public SalaryItem SalaryItem{ get; set; }

        [Display(Name = "Amount")]
        [Column(TypeName = "decimal(18, 2)")]
        [Required]
        public decimal Amount { get; set; }
    }
}
