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

namespace PayrollAppRazorPages.Pages.Manage.Salary
{
    [Authorize(Roles = "superadmin,admin")]
    public class IndexModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly PayrollAppRazorPages.Data.ApplicationDbContext _context;

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

        //[DatePickerType(DatePickerType.Months)]
        //public int month { get; set; }
        //public int year { get; set; }
        //public int flag { get; set; } = 0;
        ////public async Task<IActionResult> OnPostEdit(int y, int m)
        //public async Task<IActionResult> OnPostEdit(int yyear, int mmonth)
        //{
        //    //Console.WriteLine("hi");
        //    year = yyear;
        //    month = mmonth;
        //    await OnGetAsync();
        //    return Page();
        //}

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


            Staff = await _userManager.GetUsersInRoleAsync("staff");
            StaffSalary = new List<ViewModel>();
            var resAll = await _context.StaffSalary.Where(ss => ss.Month == int.Parse(SelectedMonth) && ss.Year == int.Parse(SelectedYear)).ToListAsync();

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
                    StaffSalary.Add(new ViewModel { Id = s.Id, Name = s.FullName, Summary = "Not Created", Mail = "", SalaryId = -1 });
                }
                else
                {
                    ViewModel vm = new ViewModel
                    {
                        Id = s.Id,
                        Name = s.FullName,
                        Summary = "Net Pay: RM " + (res.BasicSalary + res.Allowances + res.Bonus + res.AdvSalaryPlus - res.EPF - res.SocsoRm - res.EIS - res.Tax - res.AdvSalary).ToString(),
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

            //if(_context.StaffSalary.Any() && year == 0 && month == 0){
            //    year = (from c in _context.StaffSalary select c).Max(c => c.Year);
            //    month = (from c in _context.StaffSalary where c.Year == year select c).Max(c => c.Month);
            //}
            //if(year != 0 && month != 0)
            //{
            //    StaffSalary = await _context.StaffSalary.Where(x => x.Year == year).Where(x => x.Month == month).ToListAsync();
            //}
            //if(StaffSalary != null)
            //{
            //    flag = 1;
            //}
            //else
            //{
            //    StaffSalary = new List<StaffSalary>();
            //}
        }

        //public async Task OnGetAsync(int year, int month)
        //{
        //    Staff = await _userManager.GetUsersInRoleAsync("staff");
        //    StaffSalary = await _context.StaffSalary.Where(x => x.Year == year).Where(x => x.Month == month).ToListAsync();
        //}

    }
}
