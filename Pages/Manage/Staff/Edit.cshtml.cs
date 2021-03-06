﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PayrollAppRazorPages.Models;

namespace PayrollAppRazorPages.Pages.Manage.Staff
{
    [Authorize(Roles = "superadmin,admin")]
    public class EditModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public EditModel(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public ApplicationUser applicationUser { get; set; }

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

            [Display(Name = "Login username")]
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
        public async Task<IActionResult> OnGetAsync(string Id)
        {
            //applicationUser = await _userManager.FindByIdAsync(Id);
            applicationUser = await _userManager.Users.Include(x => x.StaffData).SingleOrDefaultAsync(x => x.Id == Id);

            if (applicationUser == null)
            {
                return NotFound();
            }
            bool isStaff = await _userManager.IsInRoleAsync(applicationUser, "staff");

            if (!isStaff)
            {
                return NotFound();
            }
            Input = new InputModel();
            Input.FullName = applicationUser.FullName;
            Input.ICNo = applicationUser.ICNo;
            Input.Email = applicationUser.Email;
            Input.UserName = applicationUser.UserName;

            Input.DOB = applicationUser.StaffData.DOB;
            Input.DateJoined = applicationUser.StaffData.DateJoined;
            Input.EPFNo = applicationUser.StaffData.EPFNo;
            Input.TaxNo = applicationUser.StaffData.TaxNo;
            Input.SocsoNo = applicationUser.StaffData.SocsoNo;


            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                //applicationUser = await _userManager.FindByNameAsync(Input.UserName);
                applicationUser = await _userManager.Users.Include(x => x.StaffData).SingleOrDefaultAsync(x => x.UserName == Input.UserName);


                if (applicationUser == null)
                {
                    return NotFound();
                }
                bool isStaff = await _userManager.IsInRoleAsync(applicationUser, "staff");

                if (!isStaff)
                {
                    return NotFound();
                }

                applicationUser.FullName = Input.FullName;
                applicationUser.ICNo = Input.ICNo;
                applicationUser.Email = Input.Email;
                applicationUser.NormalizedEmail = Input.Email.ToUpper();

                applicationUser.StaffData.DOB = Input.DOB;
                applicationUser.StaffData.DateJoined = Input.DateJoined;
                applicationUser.StaffData.TaxNo = Input.TaxNo;
                applicationUser.StaffData.EPFNo = Input.EPFNo;
                applicationUser.StaffData.SocsoNo = Input.SocsoNo;


                var result = await _userManager.UpdateAsync(applicationUser);
                if (result.Succeeded)
                {
                    return RedirectToPage("./Details", new { applicationUser.Id });

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