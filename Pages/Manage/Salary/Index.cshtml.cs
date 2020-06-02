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

namespace PayrollAppRazorPages
{
    [Authorize(Roles = "admin")]
    public class IndexModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;

        private readonly PayrollAppRazorPages.Data.ApplicationDbContext _context;

        public IndexModel(UserManager<ApplicationUser> userManager, PayrollAppRazorPages.Data.ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        public IList<ApplicationUser> Staff { get; set; }

        public IList<StaffSalary> StaffSalary { get; set; }

        //[DatePickerType(DatePickerType.Months)]
        public int month { get; set; }

        public int year { get; set; }

        public int flag { get; set; } = 0;

        //public async Task<IActionResult> OnPostEdit(int y, int m)
        public async Task<IActionResult> OnPostEdit(int yyear, int mmonth)
        {
            //Console.WriteLine("hi");
            year = yyear;
            month = mmonth;
            await OnGetAsync();
            return Page();
        }

        public async Task OnGetAsync()
        {
            Staff = await _userManager.GetUsersInRoleAsync("staff");
            if(year == 0 && month == 0){
                year = (from c in _context.StaffSalary select c).Max(c => c.Year);
                month = (from c in _context.StaffSalary where c.Year == year select c).Max(c => c.Month);
            }
            if(year != 0 && month != 0)
            {
                StaffSalary = await _context.StaffSalary.Where(x => x.Year == year).Where(x => x.Month == month).ToListAsync();
            }
            if(StaffSalary.Any())
            {
                flag = 1;
            }
            else
            {
                StaffSalary = new List<StaffSalary>();
            }
        }

        //public async Task OnGetAsync(int year, int month)
        //{
        //    Staff = await _userManager.GetUsersInRoleAsync("staff");
        //    StaffSalary = await _context.StaffSalary.Where(x => x.Year == year).Where(x => x.Month == month).ToListAsync();
        //}
    }
}
