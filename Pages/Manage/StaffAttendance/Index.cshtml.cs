using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PayrollAppRazorPages.Data;
using PayrollAppRazorPages.Models;

namespace PayrollAppRazorPages.Pages.Manage.StaffAttendance
{
    public class IndexModel : PageModel
    {
        private readonly PayrollAppRazorPages.Data.ApplicationDbContext _context;

        public IndexModel(PayrollAppRazorPages.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Attendance> Attendance { get;set; }

        public async Task OnGetAsync()
        {
            Attendance = await _context.Attendance
                .Include(a => a.ApplicationUser)
                .Include(a => a.AttendanceStatus).ToListAsync();
        }
    }
}
