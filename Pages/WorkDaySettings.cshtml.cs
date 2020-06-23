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
using PayrollAppRazorPages.Data.Migrations;
using PayrollAppRazorPages.Models;

namespace PayrollAppRazorPages.Pages
{
    [Authorize(Roles = "superadmin,admin")]
    public class WorkDaySettingsModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;
        [TempData]
        public string StatusMessage { get; set; }
        public WorkDaySettingsModel(UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }
        [BindProperty]
        public List<string> AreChecked { get; set; }
        public List<string> Days { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            Days = new List<string>() { "0", "1", "2", "3", "4", "5", "6" };
            GlobalSettings GlobalSettings = await _context.GlobalSettings.SingleOrDefaultAsync();
            string[] noWorkDays = GlobalSettings.NoWorkDays.Split(",");
            foreach (string s in noWorkDays)
            {
                Days.Remove(s);
            }
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                //Days = new List<string>() { "0", "1", "2", "3", "4", "5", "6" };
                //GlobalSettings GlobalSettings = await _context.GlobalSettings.SingleOrDefaultAsync();
                //string[] noWorkDays = GlobalSettings.NoWorkDays.Split(",");
                //foreach (string s in noWorkDays)
                //{
                //    Days.Remove(s);
                //}
                return Page();
            }
            Days = new List<string>() { "0", "1", "2", "3", "4", "5", "6" };
            foreach (string s in AreChecked)
            {
                Days.Remove(s);
            }
            GlobalSettings GlobalSettings = await _context.GlobalSettings.SingleOrDefaultAsync();
            GlobalSettings.NoWorkDays = string.Join(",", Days);
            _context.Attach(GlobalSettings).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            StatusMessage = "Workday Saved.";
            return Redirect("/WorkDaySettings");
        }
    }
}