﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PayrollAppRazorPages.Data;
using PayrollAppRazorPages.Models;

namespace PayrollAppRazorPages.Pages.Manage.Salaries
{
    [Authorize(Roles = "superadmin,admin")]

    public class DeleteModel : PageModel
    {
        private readonly PayrollAppRazorPages.Data.ApplicationDbContext _context;

        public DeleteModel(PayrollAppRazorPages.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public StaffSalary StaffSalary { get; set; }
        [TempData]
        public string StatusMessage { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            StaffSalary = await _context.StaffSalary.Include(m => m.staff).FirstOrDefaultAsync(m => m.salaryID == id);

            if (StaffSalary == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            StaffSalary = await _context.StaffSalary.FindAsync(id);

            if (StaffSalary != null)
            {
                _context.StaffSalary.Remove(StaffSalary);
                await _context.SaveChangesAsync();
                StatusMessage = "Staff Salary Deleted.";
            }

            return RedirectToPage("./Index", new { SelectedMonth = StaffSalary.Month, SelectedYear = StaffSalary.Year });
        }
    }
}
