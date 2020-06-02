using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
            [Required]
            public string ICNo { get; set; }

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
                    EmailConfirmed = true,
                    NormalizedEmail = Input.Email.ToUpper(),
                };

                var result = await _userManager.CreateAsync(user, Input.UserName);


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
                        ApplicationUser = user
                    };

                    await _context.StaffData.AddAsync(staffData);
                    await _context.SaveChangesAsync();

                    return RedirectToPage("CreateConfirmation", new { username = Input.UserName, password = Input.UserName});
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