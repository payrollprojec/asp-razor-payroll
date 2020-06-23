using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PayrollAppRazorPages.Data;
using PayrollAppRazorPages.Models;

namespace PayrollAppRazorPages.Pages.Manage.Salaries
{
    [Authorize(Roles = "superadmin,admin")]
    public class EditModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;
        [TempData]
        public string StatusMessage { get; set; }
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
        [BindProperty]
        public List<StaffSalaryExtra> StaffSalaryExtrasEarn { get; set; }
        [BindProperty]
        public List<StaffSalaryExtra> StaffSalaryExtrasDuct { get; set; }

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
            WeekdaysCount = _context.WeekDaysInMonth(StaffSalary.Year, StaffSalary.Month);
            //var HolidaysCount = await _context.Holiday.Where(h => h.HolidayDate.Value.Year == StaffSalary.Year && h.HolidayDate.Value.Month == StaffSalary.Month).ToListAsync();
            //WeekdaysCount -= HolidaysCount.Count();

            UserAttendance = await _context.Attendance.Include(a => a.AttendanceStatus)
                .Where(a => a.ApplicationUserId == StaffSalary.staffID && a.PunchDate.Value.Month == StaffSalary.Month && a.PunchDate.Value.Year == StaffSalary.Year)
                .OrderBy(a => a.PunchDate).ToListAsync();


            StaffSalaryExtrasEarn = await _context.StaffSalaryExtra.Include(s => s.SalaryItem).Where(s => s.StaffSalaryId == StaffSalary.salaryID && s.SalaryItem.IsDeduction == false).ToListAsync();
            StaffSalaryExtrasDuct = await _context.StaffSalaryExtra.Include(s => s.SalaryItem).Where(s => s.StaffSalaryId == StaffSalary.salaryID && s.SalaryItem.IsDeduction == true).ToListAsync();



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
                WeekdaysCount = _context.WeekDaysInMonth(StaffSalary.Year, StaffSalary.Month);

                UserAttendance = await _context.Attendance.Include(a => a.AttendanceStatus)
                    .Where(a => a.ApplicationUserId == StaffSalary.staffID && a.PunchDate.Value.Month == StaffSalary.Month && a.PunchDate.Value.Year == StaffSalary.Year)
                    .OrderBy(a => a.PunchDate).ToListAsync();

                return Page();
            }
            _context.UpdateRange(StaffSalaryExtrasEarn);
            _context.UpdateRange(StaffSalaryExtrasDuct);
            await _context.SaveChangesAsync();
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
            StatusMessage = "Staff Salary Details Updated.";

            return RedirectToPage("./Details", new { Id = StaffSalary.salaryID });

        }
        private bool StaffSalaryExists(int id)
        {
            return _context.StaffSalary.Any(e => e.salaryID == id);
        }
    }
}
