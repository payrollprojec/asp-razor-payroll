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
    [Authorize(Roles = "superadmin,admin")]


    public class CreatePayrollModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;

        private readonly PayrollAppRazorPages.Data.ApplicationDbContext _context;

        public CreatePayrollModel(UserManager<ApplicationUser> userManager, PayrollAppRazorPages.Data.ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        public IList<StaffSalary> StaffSalaryList1 { get;set; }

        public IList<StaffSalary> StaffSalaryList2 { get; set; }

        public int year, month, dyear, dmonth;

        public decimal socso, salary;

        public async Task<IActionResult> OnPostAsync(int payrollyear, int payrollmonth)
        {
            //Console.WriteLine("hi");
            year = payrollyear;
            month = payrollmonth;

            StaffSalaryList1 = await _context.StaffSalary.Where(x => x.Year == 0).Where(x => x.Month == 0).ToListAsync();

            if (_context.StaffSalary.Any())
            {
                dyear = (from c in _context.StaffSalary select c).Max(c => c.Year);
                dmonth = (from c in _context.StaffSalary select c).Max(c => c.Month);
            }

            //dmonth = (from c in _context.StaffSalary where c.Year == year select c).Max(c => c.Month);

            if (dyear != 0 && dmonth != 0)
            {
                StaffSalaryList2 = await _context.StaffSalary.Where(x => x.Year == dyear).Where(x => x.Month == dmonth).ToListAsync();
            }

            if(StaffSalaryList1 != null)
            {
                foreach (StaffSalary ss in StaffSalaryList1)
                {
                    if (ss.Socso == 1)
                    {
                        if (ss.BasicSalary < 30)
                            socso = 0.1m;
                        else if (ss.BasicSalary < 50)
                            socso = 0.2m;
                        else if (ss.BasicSalary < 70)
                            socso = 0.3m;
                        else if (ss.BasicSalary < 100)
                            socso = 0.4m;
                        else if (ss.BasicSalary < 140)
                            socso = 0.6m;
                        else if (ss.BasicSalary < 200)
                            socso = 0.85m;
                        else if (ss.BasicSalary < 300)
                            socso = 1.25m;
                        else if (ss.BasicSalary < 400)
                            socso = 1.75m;
                        else if (ss.BasicSalary < 500)
                            socso = 2.25m;
                        else if (ss.BasicSalary < 600)
                            socso = 2.75m;
                        else if (ss.BasicSalary < 700)
                            socso = 3.25m;
                        else if (ss.BasicSalary < 800)
                            socso = 3.75m;
                        else if (ss.BasicSalary < 900)
                            socso = 4.25m;
                        else if (ss.BasicSalary < 1000)
                            socso = 4.75m;
                        else if (ss.BasicSalary < 1100)
                            socso = 5.25m;
                        else if (ss.BasicSalary < 1200)
                            socso = 5.75m;
                        else if (ss.BasicSalary < 1300)
                            socso = 6.25m;
                        else if (ss.BasicSalary < 1400)
                            socso = 6.75m;
                        else if (ss.BasicSalary < 1500)
                            socso = 7.25m;
                        else if (ss.BasicSalary < 1600)
                            socso = 7.75m;
                        else if (ss.BasicSalary < 1700)
                            socso = 8.25m;
                        else if (ss.BasicSalary < 1800)
                            socso = 8.75m;
                        else if (ss.BasicSalary < 1900)
                            socso = 9.25m;
                        else if (ss.BasicSalary < 2000)
                            socso = 9.75m;
                        else if (ss.BasicSalary < 2100)
                            socso = 10.25m;
                        else if (ss.BasicSalary < 2200)
                            socso = 10.75m;
                        else if (ss.BasicSalary < 2300)
                            socso = 11.25m;
                        else if (ss.BasicSalary < 2400)
                            socso = 11.75m;
                        else if (ss.BasicSalary < 2500)
                            socso = 12.25m;
                        else if (ss.BasicSalary < 2600)
                            socso = 12.75m;
                        else if (ss.BasicSalary < 2700)
                            socso = 13.25m;
                        else if (ss.BasicSalary < 2800)
                            socso = 13.75m;
                        else if (ss.BasicSalary < 2900)
                            socso = 14.25m;
                        else if (ss.BasicSalary < 3000)
                            socso = 14.75m;
                        else if (ss.BasicSalary < 3100)
                            socso = 15.25m;
                        else if (ss.BasicSalary < 3200)
                            socso = 15.75m;
                        else if (ss.BasicSalary < 3300)
                            socso = 16.25m;
                        else if (ss.BasicSalary < 3400)
                            socso = 16.75m;
                        else if (ss.BasicSalary < 3500)
                            socso = 17.25m;
                        else if (ss.BasicSalary < 3600)
                            socso = 17.75m;
                        else if (ss.BasicSalary < 3700)
                            socso = 18.25m;
                        else if (ss.BasicSalary < 3800)
                            socso = 18.75m;
                        else if (ss.BasicSalary < 3900)
                            socso = 19.25m;
                        else
                            socso = 19.75m;
                    }
                    else
                    {
                        if (ss.BasicSalary < 30)
                            socso = 0.1m;
                        else if (ss.BasicSalary < 50)
                            socso = 0.2m;
                        else if (ss.BasicSalary < 70)
                            socso = 0.3m;
                        else if (ss.BasicSalary < 100)
                            socso = 0.4m;
                        else if (ss.BasicSalary < 140)
                            socso = 0.6m;
                        else if (ss.BasicSalary < 200)
                            socso = 0.85m;
                        else if (ss.BasicSalary < 300)
                            socso = 1.25m;
                        else if (ss.BasicSalary < 400)
                            socso = 1.75m;
                        else if (ss.BasicSalary < 500)
                            socso = 2.25m;
                        else if (ss.BasicSalary < 600)
                            socso = 2.75m;
                        else if (ss.BasicSalary < 700)
                            socso = 3.25m;
                        else if (ss.BasicSalary < 800)
                            socso = 3.75m;
                        else if (ss.BasicSalary < 900)
                            socso = 4.25m;
                        else if (ss.BasicSalary < 1000)
                            socso = 4.75m;
                        else if (ss.BasicSalary < 1100)
                            socso = 5.25m;
                        else if (ss.BasicSalary < 1200)
                            socso = 5.75m;
                        else if (ss.BasicSalary < 1300)
                            socso = 6.25m;
                        else if (ss.BasicSalary < 1400)
                            socso = 6.75m;
                        else if (ss.BasicSalary < 1500)
                            socso = 7.25m;
                        else if (ss.BasicSalary < 1600)
                            socso = 7.75m;
                        else if (ss.BasicSalary < 1700)
                            socso = 8.25m;
                        else if (ss.BasicSalary < 1800)
                            socso = 8.75m;
                        else if (ss.BasicSalary < 1900)
                            socso = 9.25m;
                        else if (ss.BasicSalary < 2000)
                            socso = 9.75m;
                        else if (ss.BasicSalary < 2100)
                            socso = 10.25m;
                        else if (ss.BasicSalary < 2200)
                            socso = 10.75m;
                        else if (ss.BasicSalary < 2300)
                            socso = 11.25m;
                        else if (ss.BasicSalary < 2400)
                            socso = 11.75m;
                        else if (ss.BasicSalary < 2500)
                            socso = 12.25m;
                        else if (ss.BasicSalary < 2600)
                            socso = 12.75m;
                        else if (ss.BasicSalary < 2700)
                            socso = 13.25m;
                        else if (ss.BasicSalary < 2800)
                            socso = 13.75m;
                        else if (ss.BasicSalary < 2900)
                            socso = 14.25m;
                        else if (ss.BasicSalary < 3000)
                            socso = 14.75m;
                        else if (ss.BasicSalary < 3100)
                            socso = 15.25m;
                        else if (ss.BasicSalary < 3200)
                            socso = 15.75m;
                        else if (ss.BasicSalary < 3300)
                            socso = 16.25m;
                        else if (ss.BasicSalary < 3400)
                            socso = 16.75m;
                        else if (ss.BasicSalary < 3500)
                            socso = 17.25m;
                        else if (ss.BasicSalary < 3600)
                            socso = 17.75m;
                        else if (ss.BasicSalary < 3700)
                            socso = 18.25m;
                        else if (ss.BasicSalary < 3800)
                            socso = 18.75m;
                        else if (ss.BasicSalary < 3900)
                            socso = 19.25m;
                        else
                            socso = 19.75m;
                    }
                    ss.Year = year;
                    ss.Month = month;
                    ss.GrossSalary = ss.BasicSalary + ss.Bonus + ss.Allowances - (ss.BasicSalary * ss.EPF / 100) - socso - ss.AdvSalary - (ss.BasicSalary * 0.002m);
                    _context.Attach(ss).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
                }
            }

            if(StaffSalaryList2 != null)
            {
                foreach (StaffSalary ss in StaffSalaryList2)
                {
                    if (ss.Socso == 1)
                    {
                        if (ss.BasicSalary < 30)
                            socso = 0.1m;
                        else if (ss.BasicSalary < 50)
                            socso = 0.2m;
                        else if (ss.BasicSalary < 70)
                            socso = 0.3m;
                        else if (ss.BasicSalary < 100)
                            socso = 0.4m;
                        else if (ss.BasicSalary < 140)
                            socso = 0.6m;
                        else if (ss.BasicSalary < 200)
                            socso = 0.85m;
                        else if (ss.BasicSalary < 300)
                            socso = 1.25m;
                        else if (ss.BasicSalary < 400)
                            socso = 1.75m;
                        else if (ss.BasicSalary < 500)
                            socso = 2.25m;
                        else if (ss.BasicSalary < 600)
                            socso = 2.75m;
                        else if (ss.BasicSalary < 700)
                            socso = 3.25m;
                        else if (ss.BasicSalary < 800)
                            socso = 3.75m;
                        else if (ss.BasicSalary < 900)
                            socso = 4.25m;
                        else if (ss.BasicSalary < 1000)
                            socso = 4.75m;
                        else if (ss.BasicSalary < 1100)
                            socso = 5.25m;
                        else if (ss.BasicSalary < 1200)
                            socso = 5.75m;
                        else if (ss.BasicSalary < 1300)
                            socso = 6.25m;
                        else if (ss.BasicSalary < 1400)
                            socso = 6.75m;
                        else if (ss.BasicSalary < 1500)
                            socso = 7.25m;
                        else if (ss.BasicSalary < 1600)
                            socso = 7.75m;
                        else if (ss.BasicSalary < 1700)
                            socso = 8.25m;
                        else if (ss.BasicSalary < 1800)
                            socso = 8.75m;
                        else if (ss.BasicSalary < 1900)
                            socso = 9.25m;
                        else if (ss.BasicSalary < 2000)
                            socso = 9.75m;
                        else if (ss.BasicSalary < 2100)
                            socso = 10.25m;
                        else if (ss.BasicSalary < 2200)
                            socso = 10.75m;
                        else if (ss.BasicSalary < 2300)
                            socso = 11.25m;
                        else if (ss.BasicSalary < 2400)
                            socso = 11.75m;
                        else if (ss.BasicSalary < 2500)
                            socso = 12.25m;
                        else if (ss.BasicSalary < 2600)
                            socso = 12.75m;
                        else if (ss.BasicSalary < 2700)
                            socso = 13.25m;
                        else if (ss.BasicSalary < 2800)
                            socso = 13.75m;
                        else if (ss.BasicSalary < 2900)
                            socso = 14.25m;
                        else if (ss.BasicSalary < 3000)
                            socso = 14.75m;
                        else if (ss.BasicSalary < 3100)
                            socso = 15.25m;
                        else if (ss.BasicSalary < 3200)
                            socso = 15.75m;
                        else if (ss.BasicSalary < 3300)
                            socso = 16.25m;
                        else if (ss.BasicSalary < 3400)
                            socso = 16.75m;
                        else if (ss.BasicSalary < 3500)
                            socso = 17.25m;
                        else if (ss.BasicSalary < 3600)
                            socso = 17.75m;
                        else if (ss.BasicSalary < 3700)
                            socso = 18.25m;
                        else if (ss.BasicSalary < 3800)
                            socso = 18.75m;
                        else if (ss.BasicSalary < 3900)
                            socso = 19.25m;
                        else
                            socso = 19.75m;
                    }
                    else
                    {
                        socso = 0;
                    }
                    ss.salaryID = 0;
                    ss.Year = year;
                    ss.Month = month;
                    ss.GrossSalary = ss.BasicSalary + ss.Bonus + ss.Allowances - (ss.BasicSalary * ss.EPF / 100) - socso - ss.AdvSalary - (ss.BasicSalary * 0.002m);
                    _context.StaffSalary.Add(ss);
                    await _context.SaveChangesAsync();
                }
            }

            //await OnGetAsync();
            return RedirectToPage("./Index");
        }

        public async Task OnGetAsync()
        {
            //StaffSalary = await _context.StaffSalary
            //    .Include(s => s.staff).ToListAsync();
        }
    }
}
