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
        public class Summary
        {
            public decimal net { get; set; }
            public decimal epf { get; set; }
            public decimal erepf { get; set; }
            public decimal socso { get; set; }
            public decimal ersocso { get; set; }
            public decimal eis { get; set; }
            public decimal ereis { get; set; }
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

            summary = new Summary();
            var SummaryList = await _context.StaffSalary.Where(ss => ss.staffID == StaffSalary.staffID && ss.Year == StaffSalary.Year && ss.Month <= StaffSalary.Month).ToListAsync();
            foreach (var v in SummaryList)
            {
                summary.net += v.BasicSalary + v.Allowances + v.Bonus + v.AdvSalaryPlus - v.EPF - v.SocsoRm - v.EIS - v.Tax - v.AdvSalary;
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