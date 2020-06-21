using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PayrollAppRazorPages.Data;
using PayrollAppRazorPages.Models;

namespace PayrollAppRazorPages.Pages.Manage.Salaries
{
    [Authorize(Roles = "superadmin,admin")]
    public class SendEmailConfirmationModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public SendEmailConfirmationModel(UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        public string Name { get; set; }
        public string Email { get; set; }
        [BindProperty(SupportsGet =true)]
        public string Month { get; set; }
        [BindProperty(SupportsGet =true)]
        public string Year{ get; set; }

        public async Task<IActionResult> OnGetAsync(string name, string email)
        {
            Name = name;
            Email = email;
           
            return Page();

        }
    }
}