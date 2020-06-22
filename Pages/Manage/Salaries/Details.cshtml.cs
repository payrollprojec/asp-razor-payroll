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

namespace PayrollAppRazorPages.Pages.Manage.Salaries
{
    [Authorize(Roles = "superadmin,admin")]
    public class DetailsModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;
        [TempData]
        public string StatusMessage { get; set; }
        public DetailsModel(UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        [BindProperty]
        public StaffSalary StaffSalary { get; set; }
        public ApplicationUser applicationUser { get; set; }
        public string SelectedDate { get; set; }
        public int WeekdaysCount { get; set; }
        public int wdc { get; set; }
        public List<Attendance> UserAttendance { get; set; }
        public List<StaffSalaryExtra> StaffSalaryExtras { get; set; }
        public Summary summary { get; set; }
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
            var HolidaysCount = await _context.Holiday.Where(h => h.HolidayDate.Value.Year == StaffSalary.Year && h.HolidayDate.Value.Month == StaffSalary.Month).ToListAsync();
            WeekdaysCount -= HolidaysCount.Count();
            UserAttendance = await _context.Attendance.Include(a => a.AttendanceStatus)
                .Where(a => a.ApplicationUserId == StaffSalary.staffID && a.PunchDate.Value.Month == StaffSalary.Month && a.PunchDate.Value.Year == StaffSalary.Year)
                .OrderBy(a => a.PunchDate).ToListAsync();
            StaffSalaryExtras = await _context.StaffSalaryExtra.Include(s => s.SalaryItem).Where(s => s.StaffSalaryId == StaffSalary.salaryID).ToListAsync();
            summary = new Summary();
            var SummaryList = await _context.StaffSalary.Include(ss => ss.StaffSalaryExtras).ThenInclude(extra => extra.SalaryItem).Where(ss => ss.staffID == StaffSalary.staffID && ss.Year == StaffSalary.Year && ss.Month <= StaffSalary.Month).ToListAsync();
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
                //var ac = await _context.Attendance
                //.Where(a => a.ApplicationUserId == v.staffID && a.PunchDate.Value.Month == v.Month && a.PunchDate.Value.Year == v.Year && a.AttendanceStatusId == 2)
                //.OrderBy(a => a.PunchDate).ToListAsync();
                //summary.net += v.BasicSalary / wdc * (wdc - ac.Count()) + v.Allowances + extraEarns + v.Bonus + v.AdvSalaryPlus - extraDucts - v.EPF - v.SocsoRm - v.EIS - v.Tax - v.AdvSalary;
                summary.net += v.BasicSalary - v.Absent + v.Allowances + extraEarns + v.Bonus + v.AdvSalaryPlus - extraDucts - v.EPF - v.SocsoRm - v.EIS - v.Tax - v.AdvSalary;
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
    }
}
