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

namespace PayrollAppRazorPages.Pages.Manage.Salary
{
    [Authorize(Roles = "superadmin,admin")]
    public class EditModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public EditModel(UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        [BindProperty]
        public StaffSalary StaffSalary { get; set; }
        public ApplicationUser applicationUser { get; set; }
        public string SelectedDate { get; set; }
        public int WeekdaysCount { get; set; }
        public List<Attendance> UserAttendance { get; set; }

        private static int WeekDaysInMonth(int year, int month)
        {
            int days = DateTime.DaysInMonth(year, month);
            List<DateTime> dates = new List<DateTime>();
            for (int i = 1; i <= days; i++)
            {
                dates.Add(new DateTime(year, month, i));
            }

            int weekDays = dates.Where(d => d.DayOfWeek < DayOfWeek.Friday).Count();
            return weekDays;
        }
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
            applicationUser = await _userManager.Users.Include(u => u.StaffData).Where(u => u.Id == StaffSalary.staffID).SingleOrDefaultAsync();
            SelectedDate = DateTime.Parse(StaffSalary.Year.ToString() + "-" + StaffSalary.Month.ToString() + "-01").ToString("MMMM yyyy");
            // get working days of this month
            WeekdaysCount = WeekDaysInMonth(StaffSalary.Year, StaffSalary.Month);
            UserAttendance = await _context.Attendance.Include(a => a.AttendanceStatus)
                .Where(a => a.ApplicationUserId == StaffSalary.staffID && a.PunchDate.Value.Month == StaffSalary.Month && a.PunchDate.Value.Year == StaffSalary.Year)
                .OrderBy(a => a.PunchDate).ToListAsync();

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            ModelState.Remove("StaffSalary.staff");
            if (!ModelState.IsValid)
            {
                StaffSalary = await _context.StaffSalary.FirstOrDefaultAsync(m => m.salaryID == StaffSalary.salaryID);

                if (StaffSalary == null)
                {
                    return NotFound();
                }
                applicationUser = await _userManager.Users.Include(u => u.StaffData).Where(u => u.Id == StaffSalary.staffID).SingleOrDefaultAsync();
                SelectedDate = DateTime.Parse(StaffSalary.Year.ToString() + "-" + StaffSalary.Month.ToString() + "-01").ToString("MMMM yyyy");
                WeekdaysCount = WeekDaysInMonth(StaffSalary.Year, StaffSalary.Month);

                UserAttendance = await _context.Attendance.Include(a => a.AttendanceStatus)
                    .Where(a => a.ApplicationUserId == StaffSalary.staffID && a.PunchDate.Value.Month == StaffSalary.Month && a.PunchDate.Value.Year == StaffSalary.Year)
                    .OrderBy(a => a.PunchDate).ToListAsync();

                return Page();
            }

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

            return RedirectToPage("./Details", new { Id = StaffSalary.salaryID});

        }
        private bool StaffSalaryExists(int id)
        {
            return _context.StaffSalary.Any(e => e.salaryID == id);
        }
    }
}