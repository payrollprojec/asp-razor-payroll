﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PayrollAppRazorPages.Models;

namespace PayrollAppRazorPages.Pages.Manage.Admin
{
    [Authorize(Roles = "superadmin")]
    public class DeleteModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public DeleteModel(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        public ApplicationUser applicationUser { get; set; }
        public async Task<IActionResult> OnGetAsync(string Id)
        {
            applicationUser = await _userManager.FindByIdAsync(Id);
            if (applicationUser == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }
            applicationUser = await _userManager.FindByIdAsync(Id);

            if (applicationUser != null)
            {
                await _userManager.DeleteAsync(applicationUser);
            }

            return RedirectToPage("./Index");
        }
    }
}