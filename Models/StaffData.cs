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

        //[DataType(DataType.Currency)]
        [Display(Name = "Basic Salary (RM)")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal BasicSalary { get; set; }

        //[DataType(DataType.Currency)]
        [Display(Name = "Fixed Allowance (RM)")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Allowances { get; set; }


        [Display(Name = "Socso Category")]
        public int Socso { get; set; }


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

        public string ApplicationUserId { get; set; }
        [Required]
        public ApplicationUser ApplicationUser { get; set; }
    }
}
