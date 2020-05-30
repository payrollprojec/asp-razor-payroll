using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PayrollAppRazorPages.Models;

namespace PayrollAppRazorPages.Pages.Manage.Staff
{
    [Authorize(Roles = "superadmin,admin")]
    public class DetailsModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public DetailsModel(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        public ApplicationUser applicationUser{ get; set; }
        public async Task<IActionResult> OnGetAsync(string Id)
        {
            applicationUser = await _userManager.FindByIdAsync(Id);
            if (applicationUser == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}