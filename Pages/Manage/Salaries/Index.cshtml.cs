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
using PayrollAppRazorPages.Models;

namespace PayrollAppRazorPages.Pages.Manage.Salaries
{
    [Authorize(Roles = "superadmin,admin")]
    public class IndexModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly PayrollAppRazorPages.Data.ApplicationDbContext _context;

        [TempData]
        public string StatusMessage { get; set; }
        public IndexModel(UserManager<ApplicationUser> userManager, PayrollAppRazorPages.Data.ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public IList<SelectListItem> Months { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SelectedMonth { get; set; }
        public SelectList Years { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SelectedYear { get; set; }
        public string SelectedDate { get; private set; }
        public int WeekdaysCount { get; set; }
        public IList<ApplicationUser> Staff { get; set; }
        public IList<ViewModel> StaffSalary { get; set; }
        public IList<ApplicationUser> Users { get; set; }

        public class ViewModel
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string Summary { get; set; }
            public string Mail { get; set; }
            public int SalaryId { get; set; }
        }
        public async Task OnGetAsync()
        {
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
            SelectedDate = DateTime.Parse(SelectedYear + "-" + SelectedMonth + "-01").ToString("MMMM yyyy");
            WeekdaysCount = WeekDaysInMonth(int.Parse(SelectedYear), int.Parse(SelectedMonth));
            // get absent day(s) for this month
            var Absent = await _context.Attendance
                .Where(a => a.PunchDate.Value.Month == int.Parse(SelectedMonth) && a.PunchDate.Value.Year == int.Parse(SelectedYear) && a.AttendanceStatusId == 2)
                .OrderBy(a => a.PunchDate).ToListAsync();

            Staff = await _userManager.GetUsersInRoleAsync("staff");
            StaffSalary = new List<ViewModel>();
            var resAll = await _context.StaffSalary.Include(ss => ss.StaffSalaryExtras).ThenInclude(extra => extra.SalaryItem).Where(ss => ss.Month == int.Parse(SelectedMonth) && ss.Year == int.Parse(SelectedYear)).ToListAsync();

            foreach (var s in Staff)
            {
                if (!string.IsNullOrEmpty(SearchString))
                {
                    // convert both to lowercase
                    if (!s.FullName.ToLower().Contains(SearchString.ToLower()))
                        continue;
                }
                var res = resAll.Find(r => r.staffID == s.Id);


                if (res == null)
                {
                    StaffSalary.Add(new ViewModel { Id = s.Id, Name = s.FullName, Summary = "Not Created", Mail = "Not Sent", SalaryId = -1 });
                }
                else
                {
                    decimal extraEarns = 0;
                    decimal extraDucts = 0;
                    foreach (var j in res.StaffSalaryExtras)
                    {
                        if (j.SalaryItem.IsDeduction == false)
                            extraEarns += j.Amount;
                        else
                            extraDucts += j.Amount;
                    }
                    var absentcount = Absent.FindAll(c => c.ApplicationUserId == s.Id);
                    ViewModel vm = new ViewModel
                    {
                        Id = s.Id,
                        Name = s.FullName,
                        Summary = "Net Pay: RM " + (res.BasicSalary / WeekdaysCount * (WeekdaysCount - absentcount.Count()) + extraEarns - extraDucts + res.Allowances + res.Bonus + res.AdvSalaryPlus - res.EPF - res.SocsoRm - res.EIS - res.Tax - res.AdvSalary).ToString("0.00"),
                        SalaryId = res.salaryID
                    };
                    if (res.MailNum > 0)
                    {
                        vm.Mail = "Sent";
                    }
                    else
                    {
                        vm.Mail = "Not Sent";
                    }
                    StaffSalary.Add(vm);
                }
            }

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