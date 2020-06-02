using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PayrollAppRazorPages.Data;
using PayrollAppRazorPages.Models;

namespace PayrollAppRazorPages.Pages.Manage.Attendances
{
    [Authorize(Roles = "superadmin,admin")]
    public class IndexModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(UserManager<ApplicationUser> userManager, ApplicationDbContext context, ILogger<IndexModel> logger)
        {
            _userManager = userManager;
            _context = context;
            _logger = logger;
        }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public IList<SelectListItem> Months{ get; set; }
        [BindProperty(SupportsGet = true)]
        public string SelectedMonth { get; set; }
        public SelectList Years { get; set; }
        public string SelectedDate { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SelectedYear{ get; set; }

        public IList<ApplicationUser> Users { get; set; }

        public IList<ViewModel> UserAttendances { get; set; }

        public class ViewModel
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public int DaysRecorded { get; set; }
        }

        public async Task OnGetAsync()
        {
            string[] monthArr = new string[] { "January", "February", "March", "April", "May", "June", 
                "July", "August", "September", "October", "November", "December" };
            Months = new List<SelectListItem>();
            for (int i = 0; i < 12; i++)
            {
                Months.Add(new SelectListItem(monthArr[i], (i+1).ToString()));
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

            Users = await _userManager.GetUsersInRoleAsync("staff");

            UserAttendances = new List<ViewModel>();

            // for each of the users with role "staff", count the number of attendance rows with year and month specified
            foreach(var u in Users)
            {
                if (!string.IsNullOrEmpty(SearchString))
                {
                    // convert both to lowercase
                    if (!u.FullName.ToLower().Contains(SearchString.ToLower()))
                        continue;
                }
                var num = await _context.Attendance.Where(
                    a => a.PunchDate.Value.Month == int.Parse(SelectedMonth) &&
                    a.PunchDate.Value.Year == int.Parse(SelectedYear) &&
                    a.ApplicationUserId == u.Id).ToListAsync();

                _logger.LogInformation(u.Id);
                UserAttendances.Add(new ViewModel { Id=u.Id, Name = u.FullName, DaysRecorded = num.Count() });
            }
        }
    }
}