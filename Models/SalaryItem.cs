using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PayrollAppRazorPages.Models
{
    public class SalaryItem
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Name{ get; set; }

        [Display(Name = "Default Amount")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal DefaultAmount { get; set; }

        public bool IsDeduction { get; set; }
    }
}
