using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PayrollAppRazorPages.Models
{
    public class StaffSalaryExtra
    {
        public int Id { get; set; }
        public int StaffSalaryId{ get; set; }
        [Required]
        public StaffSalary StaffSalary { get; set; }
        public int SalaryItemId { get; set; }
        public SalaryItem SalaryItem{ get; set; }

        [Display(Name = "Amount")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Amount { get; set; }
    }
}
