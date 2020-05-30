using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PayrollAppRazorPages.Data;
using PayrollAppRazorPages.Models;

namespace PayrollAppRazorPages.Pages.Manage.StaffAttendance
{
    public class CreateModel : PageModel
    {
        private readonly PayrollAppRazorPages.Data.ApplicationDbContext _context;

        public CreateModel(PayrollAppRazorPages.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["ApplicationUserId"] = new SelectList(_context.Users, "Id", "Id");
            ViewData["AttendanceStatusId"] = new SelectList(_context.AttendanceStatus, "Id", "Status");
            return Page();
        }

        [BindProperty]
        public Attendance Attendance { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            
            _context.Attendance.Add(Attendance);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
