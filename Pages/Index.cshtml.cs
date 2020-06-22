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
        public string ComingHoliday { get; set; }
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

            Holiday = await _context.Holiday.ToListAsync();

            //if there is no holiday added
            if (Holiday.Count() == 0)
            {
                ComingHoliday = "Not available yet.";
            }
            else
            {
                int nextMon = int.Parse(todayMon) + 1;
                int nextYear = int.Parse(todayYear) + 1;

                // December
                if (nextMon == 13)
                {
                    var closeHoliday = await _context.Holiday.Where(a => a.HolidayDate.Value.Year >= nextYear).OrderBy(a => a.HolidayDate).Take(1).ToListAsync();
                    if (closeHoliday.Count() == 0)
                        ComingHoliday = "Not available yet.";
                    else
                        ComingHoliday = ((DateTime)closeHoliday[0].HolidayDate).ToString("dd/MM/yyyy") + " - " + closeHoliday[0].HolidayDes;
                }
                else
                {
                    var closeHoliday = await _context.Holiday.Where(a => a.HolidayDate.Value.Month >= int.Parse(todayMon) && a.HolidayDate.Value.Day >= int.Parse(todayDay)).OrderBy(a => a.HolidayDate).Take(1).ToListAsync();
                    if (closeHoliday.Count() == 0)
                        ComingHoliday = "Not available yet.";
                    else
                        ComingHoliday = ((DateTime)closeHoliday[0].HolidayDate).ToString("dd/MM/yyyy") + " - " + closeHoliday[0].HolidayDes;
                }

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

                var SummaryList = await _context.StaffSalary.Include(ss => ss.StaffSalaryExtras).ThenInclude(extra => extra.SalaryItem).Where(ss => ss.Year == int.Parse(todayYear)).ToListAsync();
                foreach (var v in SummaryList)
                {
                    decimal extraEarns = 0;
                    decimal extraDucts = 0;
                    foreach (var j in v.StaffSalaryExtras)
                    {
                        if (j.SalaryItem.IsDeduction == false)
                            extraEarns += j.Amount;
                        else
                            extraDucts += j.Amount;
                    }

                    summary.net += v.BasicSalary - v.Absent + extraEarns - extraDucts + v.Allowances + v.Bonus + v.AdvSalaryPlus - v.EPF - v.SocsoRm - v.EIS - v.Tax - v.AdvSalary;
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
                var SummaryList = await _context.StaffSalary.Include(ss => ss.StaffSalaryExtras).ThenInclude(extra => extra.SalaryItem).Where(ss => ss.staffID == applicationUser.Id && ss.Year == int.Parse(todayYear)).ToListAsync();
                foreach (var v in SummaryList)
                {
                    decimal extraEarns = 0;
                    decimal extraDucts = 0;
                    foreach (var j in v.StaffSalaryExtras)
                    {
                        if (j.SalaryItem.IsDeduction == false)
                            extraEarns += j.Amount;
                        else
                            extraDucts += j.Amount;
                    }
                    //wdc = WeekDaysInMonth(v.Year, v.Month);

                    //summary.net += v.BasicSalary / wdc * (wdc - ac.Count()) + v.Allowances + v.Bonus + v.AdvSalaryPlus - v.EPF - v.SocsoRm - v.EIS - v.Tax - v.AdvSalary;
                    summary.net += v.BasicSalary - v.Absent + extraEarns - extraDucts + v.Allowances + v.Bonus + v.AdvSalaryPlus - v.EPF - v.SocsoRm - v.EIS - v.Tax - v.AdvSalary;
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
