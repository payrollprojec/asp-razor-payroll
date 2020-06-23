using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PayrollAppRazorPages.Data;
using PayrollAppRazorPages.Models;

namespace PayrollAppRazorPages.Pages.Staff
{
    [Authorize(Roles ="staff")]
    public class AttendanceModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public AttendanceModel(UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }
        public ApplicationUser applicationUser { get; set; }
        public IList<Attendance> UserAttendance { get; set; }
        public IList<SelectListItem> Months { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SelectedMonth { get; set; }

        public SelectList Years { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SelectedYear { get; set; }

        public IList<Holiday> SelectedMonHoliday { get; set; }
        public int WeekdaysCount { get; set; }
        public string[] Days { get; set; }
        public List<Holiday> Holidays { get; set; }
        public string SelectedDate { get; private set; }
        public async Task<IActionResult> OnGetAsync()
        {
            applicationUser = await _userManager.GetUserAsync(User);  // User = logged in user (built in magic)

            if (applicationUser == null)
            {
                return NotFound();
            }
            bool isStaff = await _userManager.IsInRoleAsync(applicationUser, "staff");
            if (!isStaff)
            {
                return NotFound();
            }

            string[] monthArr = new string[] { "January", "February", "March", "April", "May", "June",
                "July", "August", "September", "October", "November", "December" };
            Months = new List<SelectListItem>();
            for (int i = 0; i < 12; i++)
            {
                Months.Add(new SelectListItem(monthArr[i], (i + 1).ToString()));
            }
            var yearLow = 2020;
            var yearNow = DateTime.Now.Year;

            var yearList = new List<string>();

            // generate list of years, starting with a fixed 2020.
            // if year now is 2022, the list would contain 2020,2021,2022
            while (yearNow >= yearLow)
            {
                //_logger.LogInformation(yearLow.ToString());
                yearList.Add(yearLow.ToString());
                yearLow++;
            }
            Years = new SelectList(yearList);

            if (string.IsNullOrEmpty(SelectedYear) || string.IsNullOrEmpty(SelectedMonth))
            {
                SelectedMonth = DateTime.Now.Month.ToString();
                SelectedYear = DateTime.Now.Year.ToString();
            }

            //SelectedMonHoliday = await _context.Holiday
            //    .Where(a => a.HolidayDate.Value.Year == int.Parse(SelectedYear) && a.HolidayDate.Value.Month == int.Parse(SelectedMonth))
            //    .OrderBy(a => a.HolidayDate).ToListAsync();

            UserAttendance = await _context.Attendance.Include(a => a.AttendanceStatus)
                .Where(a => a.ApplicationUserId == applicationUser.Id && a.PunchDate.Value.Month == int.Parse(SelectedMonth) && a.PunchDate.Value.Year == int.Parse(SelectedYear))
                .OrderBy(a => a.PunchDate).ToListAsync();

            WeekdaysCount = _context.WeekDaysInMonth(int.Parse(SelectedYear), int.Parse(SelectedMonth));
            GlobalSettings GlobalSettings = await _context.GlobalSettings.SingleOrDefaultAsync();
            Days = GlobalSettings.NoWorkDays.Split(",");
            Holidays = await _context.Holiday.Where(h => h.HolidayDate.Value.Year == int.Parse(SelectedYear) && h.HolidayDate.Value.Month == int.Parse(SelectedMonth)).ToListAsync();
            WeekdaysCount = _context.WeekDaysInMonth(int.Parse(SelectedYear), int.Parse(SelectedMonth));
            SelectedDate = DateTime.Parse(SelectedYear + "-" + SelectedMonth + "-01").ToString("MMMM yyyy");
            return Page();
        }
    }
}