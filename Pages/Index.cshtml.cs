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

namespace PayrollAppRazorPages.Pages
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<IndexModel> _logger;
        private readonly ApplicationDbContext _context;

        public int AdminNum { get; set; }
        public int StaffNum { get; set; }
        public int AttendanceCount { get; set; }
        public String RecordStatus { get; set; }
        public string TodayDate { get; set; }
        public ApplicationUser applicationUser { get; set; }
        public IList<ApplicationUser> Staff { get; set; }
        public IList<ApplicationUser> Admin { get; set; }
        public Attendance TodayAttendance { get; set; }

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
            }
            

            if (User.IsInRole("staff"))
            {
                TodayDate = DateTime.Today.ToString("dd.MM.yyy");

                applicationUser = await _userManager.GetUserAsync(User);  // User = logged in user (built in magic)
                TodayAttendance = await _context.Attendance.Where(
                    a => a.ApplicationUserId == applicationUser.Id &&
                    a.PunchDate.Value.Day == int.Parse(todayDay) &&
                    a.PunchDate.Value.Month == int.Parse(todayMon) &&
                    a.PunchDate.Value.Year == int.Parse(todayYear)).SingleOrDefaultAsync();
                if (TodayAttendance == null)
                {
                    RecordStatus = "Today's attendance: Not recorded yet.";
                }
                else
                {
                    RecordStatus = "Today's attendance: Recorded.";

                }
            }
        }
    }
}
