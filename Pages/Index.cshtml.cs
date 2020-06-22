using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PayrollAppRazorPages.Models;
using PayrollAppRazorPages.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace PayrollAppRazorPages.Pages
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<IndexModel> _logger;
        private readonly ApplicationDbContext _context;

        public int wdc { get; set; }
        public int WeekdaysCount { get; set; }

        public int AdminNum { get; set; }
        public int StaffNum { get; set; }
        public int AttendanceCount { get; set; }
        public String RecordStatus { get; set; }
        public string TodayDate { get; set; }
        public ApplicationUser applicationUser { get; set; }
        public IList<ApplicationUser> Staff { get; set; }
        public IList<ApplicationUser> Admin { get; set; }
        public Attendance TodayAttendance { get; set; }
        public Summary summary { get; set; }
        public IList<Holiday> Holiday { get; set; }
        public string ComingHoliday { get; set;  }
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
        public IndexModel(UserManager<ApplicationUser> userManager, ILogger<IndexModel> logger, PayrollAppRazorPages.Data.ApplicationDbContext context)
        {
            _userManager = userManager;
            _logger = logger;
            _context = context;
        }

        //public void OnGet()
        public async Task OnGetAsync()
        {
            var todayDay = DateTime.Today.Day.ToString();
            var todayMon = DateTime.Today.Month.ToString();
            var todayYear = DateTime.Today.Year.ToString();

            Holiday = await _context.Holiday.OrderBy(a => a.HolidayDate).ToListAsync();
            if (Holiday.Count() == 0)
            {
                ComingHoliday = "Not available yet.";
            }
            else
            {
                var v = await _context.Holiday.Where(a => a.HolidayDate.Value.Month == int.Parse(todayMon)).SingleOrDefaultAsync();
                if (v != null)
                    ComingHoliday = v.HolidayDate + " " + v.HolidayDes;
            }

            if (User.IsInRole("superadmin") || User.IsInRole("admin"))
            {
                Staff = await _userManager.GetUsersInRoleAsync("staff");
                StaffNum = Staff.Count();

                Admin = await _userManager.GetUsersInRoleAsync("admin");
                AdminNum = Admin.Count();
                var num = await _context.Attendance.Where(
                 a => a.PunchDate.Value.Day == int.Parse(todayDay) &&
                   a.PunchDate.Value.Month == int.Parse(todayMon) &&
                    a.PunchDate.Value.Year == int.Parse(todayYear)).ToListAsync();

                AttendanceCount = num.Count();
                summary = new Summary();

                var SummaryList = await _context.StaffSalary.Where(ss => ss.Year == int.Parse(todayYear)).ToListAsync();
                foreach (var v in SummaryList)
                {
                    wdc = WeekDaysInMonth(v.Year, v.Month);
                    var ac = await _context.Attendance
                    .Where(a => a.ApplicationUserId == v.staffID && a.PunchDate.Value.Month == v.Month && a.PunchDate.Value.Year == v.Year && a.AttendanceStatusId == 2)
                    .OrderBy(a => a.PunchDate).ToListAsync();
                    summary.net += v.BasicSalary / wdc * (wdc - ac.Count()) + v.Allowances + v.Bonus + v.AdvSalaryPlus - v.EPF - v.SocsoRm - v.EIS - v.Tax - v.AdvSalary;
                    //summary.net += v.BasicSalary + v.Allowances + v.Bonus + v.AdvSalaryPlus - v.EPF - v.SocsoRm - v.EIS - v.Tax - v.AdvSalary;

                }
            }
            

            if (User.IsInRole("staff"))
            {
                TodayDate = DateTime.Today.ToString("dd.MM.yyy");

                applicationUser = await _userManager.GetUserAsync(User);  // User = logged in user (built in magic)
                TodayAttendance = await _context.Attendance.Where(
                    a => a.ApplicationUserId == applicationUser.Id &&
                    a.PunchDate.Value.Day == int.Parse(todayDay) &&
                    a.PunchDate.Value.Month == int.Parse(todayMon) &&
                    a.PunchDate.Value.Year == int.Parse(todayYear)).Include(a => a.AttendanceStatus).SingleOrDefaultAsync();

                summary = new Summary();
                var SummaryList = await _context.StaffSalary.Where(ss => ss.staffID == applicationUser.Id && ss.Year == int.Parse(todayYear)).ToListAsync();
                foreach (var v in SummaryList)
                {
                    wdc = WeekDaysInMonth(v.Year, v.Month);
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

                if (TodayAttendance == null)
                {
                    RecordStatus = "Today's attendance: No record.";
                }
                else
                {
                    RecordStatus = "Today's attendance: " + TodayAttendance.AttendanceStatus.Status;
                }
            }
        }
    }
}
