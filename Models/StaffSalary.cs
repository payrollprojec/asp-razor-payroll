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

        public List<StaffSalaryExtra> StaffSalaryExtras { get; set; }

        public string staffID { get; set; }

        [Required]
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

        [Display(Name = "Generated On")]
        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }

        [Display(Name = "Socso Category")]
        public int Socso { get; set; }

        //[DataType(DataType.Currency)]
        [Display(Name = "Basic Salary")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal BasicSalary { get; set; }

        //[DataType(DataType.Currency)]
        [Display(Name = "Bonus")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Bonus { get; set; }

        //[DataType(DataType.Currency)]
        [Display(Name = "Fixed Allowance")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Allowances { get; set; }

        //[DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        [Display(Name = "Tax (RM)")]
        public decimal Tax { get; set; }

        //[DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        [Display(Name = "Employee EPF (RM)")]
        public decimal EPF { get; set; }

        //[DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        [Display(Name = "Employer EPF (RM)")]
        public decimal EREPF { get; set; }


        //[DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        [Display(Name = "Employee Socso (RM)")]
        public decimal SocsoRm { get; set; }

        //[DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        [Display(Name = "Employer Socso (RM)")]
        public decimal ERSocsoRm { get; set; }

        //[DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        [Display(Name = "Employee EIS (RM)")]
        public decimal EIS { get; set; }

        //[DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        [Display(Name = "Employer EIS (RM)")]
        public decimal EREIS { get; set; }

        //[DataType(DataType.Currency)]
        [Display(Name = "Gross Salary (RM)")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal AdvSalaryPlus { get; set; }

        //[DataType(DataType.Currency)]
        [Display(Name = "Advanced Salary (RM)")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal AdvSalary { get; set; }

        [Display(Name = "Absent (RM)")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Absent { get; set; }
        public int MailNum { get; set; }
    }
}
