using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using PayrollAppRazorPages.Data;
using PayrollAppRazorPages.Models;

namespace PayrollAppRazorPages.Pages.Manage.Staff
{
    [Authorize(Roles = "superadmin,admin")]
    public class CreateModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public CreateModel(UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [StringLength(60, MinimumLength = 3)]
            [Display(Name = "Name")]
            [Required]
            public string FullName { get; set; }

            [Display(Name = "I/C No")]
            [StringLength(12, MinimumLength = 12)]
            [Required]
            public string ICNo { get; set; }

            [Phone]
            [Display(Name = "Phone number")]
            public string PhoneNumber { get; set; }

            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [StringLength(20, MinimumLength = 3)]
            [Display(Name = "Login username")]
            [Required]
            public string UserName { get; set; }

            // Staff extra details
            [Required]
            [Display(Name = "Date of Birth")]
            [DataType(DataType.Date)]
            public DateTime? DOB { get; set; }

            [Required]
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
            [Display(Name = "Basic Salary (RM)")]
            [Column(TypeName = "decimal(18, 2)")]
            public decimal BasicSalary { get; set; }

            [DataType(DataType.Currency)]
            [Display(Name = "Fixed Allowance (RM)")]
            [Column(TypeName = "decimal(18, 2)")]
            public decimal Allowances { get; set; }


            [Display(Name = "Socso Category")]
            public int Socso { get; set; }


            [DataType(DataType.Currency)]
            [Column(TypeName = "decimal(18, 2)")]
            [Display(Name = "Tax (RM)")]
            public decimal Tax { get; set; }

            [DataType(DataType.Currency)]
            [Column(TypeName = "decimal(18, 2)")]
            [Display(Name = "Employee EPF (RM)")]
            public decimal EPF { get; set; }

            [DataType(DataType.Currency)]
            [Column(TypeName = "decimal(18, 2)")]
            [Display(Name = "Employer EPF (RM)")]
            public decimal EREPF { get; set; }


            [DataType(DataType.Currency)]
            [Column(TypeName = "decimal(18, 2)")]
            [Display(Name = "Employee Socso (RM)")]
            public decimal SocsoRm { get; set; }

            [DataType(DataType.Currency)]
            [Column(TypeName = "decimal(18, 2)")]
            [Display(Name = "Employer Socso (RM)")]
            public decimal ERSocsoRm { get; set; }

            [DataType(DataType.Currency)]
            [Column(TypeName = "decimal(18, 2)")]
            [Display(Name = "Employee EIS (RM)")]
            public decimal EIS { get; set; }

            [DataType(DataType.Currency)]
            [Column(TypeName = "decimal(18, 2)")]
            [Display(Name = "Employer EIS (RM)")]
            public decimal EREIS { get; set; }

            //[Required]
            //[StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            //[DataType(DataType.Password)]
            //[Display(Name = "Password")]
            //public string Password { get; set; }

            //[DataType(DataType.Password)]
            //[Display(Name = "Confirm password")]
            //[Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            //public string ConfirmPassword { get; set; }
        }
        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser 
                {
                    UserName = Input.UserName,
                    Email = Input.Email,
                    FullName = Input.FullName,
                    ICNo = Input.ICNo,
                    PhoneNumber = Input.PhoneNumber,
                    EmailConfirmed = true,
                    NormalizedEmail = Input.Email.ToUpper(),
                };
                string pw = "123456";

                var result = await _userManager.CreateAsync(user, pw);


                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "staff");

                    var staffData = new StaffData
                    {
                        DOB = Input.DOB,
                        DateJoined = Input.DateJoined,
                        TaxNo = Input.TaxNo,
                        EPFNo = Input.EPFNo,
                        SocsoNo = Input.SocsoNo,
                        ApplicationUser = user,

                        BasicSalary = Input.BasicSalary,
                        Allowances = Input.Allowances,
                        EPF = Input.EPF,
                        EREPF = Input.EREPF,
                        Socso = Input.Socso,
                        SocsoRm = Input.SocsoRm,
                        ERSocsoRm = Input.ERSocsoRm,
                        EIS = Input.EIS,
                        EREIS = Input.EREIS,
                        Tax = Input.Tax
                    };

                    await _context.StaffData.AddAsync(staffData);
                    await _context.SaveChangesAsync();
                    return RedirectToPage("CreateConfirmation", new { username = Input.UserName, password = pw });
                    //return RedirectToPage("../Salary/Create", new { username = Input.UserName, password = Input.UserName, userid = user.Id });
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return Page();
        }
    }
}