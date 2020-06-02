using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PayrollAppRazorPages.Data;
using PayrollAppRazorPages.Models;

namespace PayrollAppRazorPages
{
    public class EditModel : PageModel
    {
        private readonly PayrollAppRazorPages.Data.ApplicationDbContext _context;

        public EditModel(PayrollAppRazorPages.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public StaffSalary StaffSalary { get; set; }

        public decimal socso;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            StaffSalary = await _context.StaffSalary.FirstOrDefaultAsync(m => m.salaryID == id);

            if (StaffSalary == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (StaffSalary.Socso == 1)
            {
                if (StaffSalary.BasicSalary < 30)
                    socso = 0.1m;
                else if (StaffSalary.BasicSalary < 50)
                    socso = 0.2m;
                else if (StaffSalary.BasicSalary < 70)
                    socso = 0.3m;
                else if (StaffSalary.BasicSalary < 100)
                    socso = 0.4m;
                else if (StaffSalary.BasicSalary < 140)
                    socso = 0.6m;
                else if (StaffSalary.BasicSalary < 200)
                    socso = 0.85m;
                else if (StaffSalary.BasicSalary < 300)
                    socso = 1.25m;
                else if (StaffSalary.BasicSalary < 400)
                    socso = 1.75m;
                else if (StaffSalary.BasicSalary < 500)
                    socso = 2.25m;
                else if (StaffSalary.BasicSalary < 600)
                    socso = 2.75m;
                else if (StaffSalary.BasicSalary < 700)
                    socso = 3.25m;
                else if (StaffSalary.BasicSalary < 800)
                    socso = 3.75m;
                else if (StaffSalary.BasicSalary < 900)
                    socso = 4.25m;
                else if (StaffSalary.BasicSalary < 1000)
                    socso = 4.75m;
                else if (StaffSalary.BasicSalary < 1100)
                    socso = 5.25m;
                else if (StaffSalary.BasicSalary < 1200)
                    socso = 5.75m;
                else if (StaffSalary.BasicSalary < 1300)
                    socso = 6.25m;
                else if (StaffSalary.BasicSalary < 1400)
                    socso = 6.75m;
                else if (StaffSalary.BasicSalary < 1500)
                    socso = 7.25m;
                else if (StaffSalary.BasicSalary < 1600)
                    socso = 7.75m;
                else if (StaffSalary.BasicSalary < 1700)
                    socso = 8.25m;
                else if (StaffSalary.BasicSalary < 1800)
                    socso = 8.75m;
                else if (StaffSalary.BasicSalary < 1900)
                    socso = 9.25m;
                else if (StaffSalary.BasicSalary < 2000)
                    socso = 9.75m;
                else if (StaffSalary.BasicSalary < 2100)
                    socso = 10.25m;
                else if (StaffSalary.BasicSalary < 2200)
                    socso = 10.75m;
                else if (StaffSalary.BasicSalary < 2300)
                    socso = 11.25m;
                else if (StaffSalary.BasicSalary < 2400)
                    socso = 11.75m;
                else if (StaffSalary.BasicSalary < 2500)
                    socso = 12.25m;
                else if (StaffSalary.BasicSalary < 2600)
                    socso = 12.75m;
                else if (StaffSalary.BasicSalary < 2700)
                    socso = 13.25m;
                else if (StaffSalary.BasicSalary < 2800)
                    socso = 13.75m;
                else if (StaffSalary.BasicSalary < 2900)
                    socso = 14.25m;
                else if (StaffSalary.BasicSalary < 3000)
                    socso = 14.75m;
                else if (StaffSalary.BasicSalary < 3100)
                    socso = 15.25m;
                else if (StaffSalary.BasicSalary < 3200)
                    socso = 15.75m;
                else if (StaffSalary.BasicSalary < 3300)
                    socso = 16.25m;
                else if (StaffSalary.BasicSalary < 3400)
                    socso = 16.75m;
                else if (StaffSalary.BasicSalary < 3500)
                    socso = 17.25m;
                else if (StaffSalary.BasicSalary < 3600)
                    socso = 17.75m;
                else if (StaffSalary.BasicSalary < 3700)
                    socso = 18.25m;
                else if (StaffSalary.BasicSalary < 3800)
                    socso = 18.75m;
                else if (StaffSalary.BasicSalary < 3900)
                    socso = 19.25m;
                else
                    socso = 19.75m;
            }
            else
            {
                socso = 0;
            }

            StaffSalary.GrossSalary = StaffSalary.BasicSalary + StaffSalary.Bonus + StaffSalary.Allowances - (StaffSalary.BasicSalary * StaffSalary.EPF / 100) - socso - StaffSalary.AdvSalary - (StaffSalary.BasicSalary * 0.002m);

            _context.Attach(StaffSalary).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StaffSalaryExists(StaffSalary.salaryID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool StaffSalaryExists(int id)
        {
            return _context.StaffSalary.Any(e => e.salaryID == id);
        }
    }
}
