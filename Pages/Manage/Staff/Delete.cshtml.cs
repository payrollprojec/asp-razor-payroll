using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PayrollAppRazorPages.Data;
using PayrollAppRazorPages.Models;

namespace PayrollAppRazorPages.Pages.Manage.Staff
{
    [Authorize(Roles = "superadmin,admin")]
    public class DeleteModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;
        [TempData]
        public string StatusMessage { get; set; }
        public DeleteModel(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        public ApplicationUser applicationUser { get; set; }
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
                bool isStaff = await _userManager.IsInRoleAsync(applicationUser, "staff");

                if (isStaff)
                {
                    await _userManager.DeleteAsync(applicationUser);
                    StatusMessage = "Staff Account Deleted.";

                }
            }

            return RedirectToPage("./Index");
        }
    }
}