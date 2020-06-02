using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollAppRazorPages.Models
{
    public class StaffSalary
    {
        [Key]
        public int salaryID { get; set; }

        public string staffID { get; set; }

        [ForeignKey("staffID")]
        public virtual ApplicationUser staff { get; set; }

        //public JsonObject<string[]> Tags { get; set; }

        //[DataType(DataType.Date)]
        //[Display(Name = "Date")]
        //[DisplayFormat(DataFormatString = "{0:MM/yyyy}", ApplyFormatInEditMode = true)]
        //[DatePickerType(DatePickerType.Months)]
        //public DateTime? Date { get; set; }

        public int Month { get; set; }

        public int Year { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Basic Salary")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? BasicSalary { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Bonus")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Bonus { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Allowances")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Allowances { get; set; }

        [Display(Name = "EPF (%)")]
        public int? EPF { get; set; }

        [Display(Name = "Socso Category")]
        public int? Socso { get; set; }

        //[DataType(DataType.Currency)]
        //[Display(Name = "Tax")]
        //[Column(TypeName = "decimal(18, 2)")]
        //public decimal? Tax { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Advanced Salary")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? AdvSalary { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Gross Salary")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? GrossSalary { get; set; }
    }
}
