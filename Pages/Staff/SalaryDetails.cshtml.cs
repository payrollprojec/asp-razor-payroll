using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PayrollAppRazorPages.Data;
using PayrollAppRazorPages.Models;

namespace PayrollAppRazorPages.Pages.Staff
{
    public class SalaryDetailsModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;
        public ApplicationUser applicationUser { get; set; }

        public SalaryDetailsModel(UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        public StaffSalary StaffSalary { get; set; }
        public string SelectedDate { get; set; }
        public List<Attendance> UserAttendance { get; set; }
        public Summary summary { get; set; }
        public int WeekdaysCount { get; set; }

        public class Summary
        {
            [Column(TypeName = "decimal(18, 2)")]
            public decimal net { get; set; }
            [Column(TypeName = "decimal(18, 2)")]
            public decimal epf { get; set; }
            [Column(TypeName = "decimal(18, 2)")]
            public decimal erepf { get; set; }
            [Column(TypeName = "decimal(18, 2)")]
            public decimal socso { get; set; }
            [Column(TypeName = "decimal(18, 2)")]
            public decimal ersocso { get; set; }
            [Column(TypeName = "decimal(18, 2)")]
            public decimal eis { get; set; }
            [Column(TypeName = "decimal(18, 2)")]
            public decimal ereis { get; set; }
            [Column(TypeName = "decimal(18, 2)")]
            public decimal tax { get; set; }
        }
        public async Task<IActionResult> OnGetAsync(int? Id, string key)
        {
            if (key == null)
            {
                applicationUser = await _userManager.GetUserAsync(User);  // User = logged in user (built in magic)
                if (applicationUser == null)
                {
                    return NotFound();
                }
                applicationUser = await _userManager.Users.Include(u => u.StaffData).Where(u => u.Id == applicationUser.Id).SingleOrDefaultAsync();
                if (applicationUser == null)
                {
                    return NotFound();
                }
                StaffSalary = await _context.StaffSalary.Where(ss => ss.staffID == applicationUser.Id && ss.salaryID == Id).SingleOrDefaultAsync();
                if (StaffSalary == null)
                {
                    return NotFound();
                }
            }
            else
            {
                applicationUser = await _userManager.Users.Include(u => u.StaffData).Where(u => u.Id == key).SingleOrDefaultAsync();
                if (applicationUser == null)
                {
                    return NotFound();
                }
                StaffSalary = await _context.StaffSalary.Where(ss => ss.staffID == applicationUser.Id && ss.salaryID == Id).SingleOrDefaultAsync();
                if (StaffSalary == null)
                {
                    return NotFound();
                }
            }
            
            SelectedDate = DateTime.Parse(StaffSalary.Year.ToString() + "-" + StaffSalary.Month.ToString() + "-01").ToString("MMMM yyyy");

            UserAttendance = await _context.Attendance.Include(a => a.AttendanceStatus)
                .Where(a => a.ApplicationUserId == StaffSalary.staffID && a.PunchDate.Value.Month == StaffSalary.Month && a.PunchDate.Value.Year == StaffSalary.Year)
                .OrderBy(a => a.PunchDate).ToListAsync();
            WeekdaysCount = WeekDaysInMonth(StaffSalary.Year, StaffSalary.Month);
            summary = new Summary();
            var SummaryList = await _context.StaffSalary.Where(ss => ss.staffID == StaffSalary.staffID && ss.Year == StaffSalary.Year && ss.Month <= StaffSalary.Month).ToListAsync();
            foreach (var v in SummaryList)
            {
                int wdc = WeekDaysInMonth(v.Year, v.Month);
                var ac = await _context.Attendance
                .Where(a => a.ApplicationUserId == v.staffID && a.PunchDate.Value.Month == v.Month && a.PunchDate.Value.Year == v.Year && a.AttendanceStatusId == 2)
                .OrderBy(a => a.PunchDate).ToListAsync();
                summary.net += v.BasicSalary / wdc * (wdc - ac.Count()) + v.Allowances + v.Bonus + v.AdvSalaryPlus - v.EPF - v.SocsoRm - v.EIS - v.Tax - v.AdvSalary;
                //summary.net += v.BasicSalary + v.Allowances + v.Bonus + v.AdvSalaryPlus - v.EPF - v.SocsoRm - v.EIS - v.Tax - v.AdvSalary;
                summary.epf += v.EPF;
                summary.erepf += v.EREPF;
                summary.socso += v.SocsoRm;
                summary.ersocso += v.ERSocsoRm;
                summary.eis += v.EIS;
                summary.ereis += v.EREIS;
                summary.tax += v.Tax;
            }
            return Page();
        }
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
    }
}