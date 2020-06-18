﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

namespace PayrollAppRazorPages.Pages.Staff
{
    [Authorize(Roles = "staff")]
    public class SalaryModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public SalaryModel(UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }
        public ApplicationUser applicationUser { get; set; }

        public SelectList Years { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SelectedYear { get; set; }
        public List<StaffSalary> StaffSalary { get; set; }
        public List<ViewModel> SalaryList { get; set; }
        public class ViewModel
        {
            [Column(TypeName = "decimal(18, 2)")]

            public decimal Net { get; set; }
            public int Id { get; set; }
            public DateTime GenDate { get; set; }
            public string Month { get; set; }
        }

        public async Task<IActionResult> OnGetAsync()
        {
            applicationUser = await _userManager.GetUserAsync(User);  // User = logged in user (built in magic)

            if (applicationUser == null)
            {
                return NotFound();
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

            if (string.IsNullOrEmpty(SelectedYear))
            {
                SelectedYear = DateTime.Now.Year.ToString();
            }
            string[] monthArr = new string[] { "January", "February", "March", "April", "May", "June",
                "July", "August", "September", "October", "November", "December" };

            StaffSalary = await _context.StaffSalary.Where(ss => ss.staffID == applicationUser.Id && ss.Year == int.Parse(SelectedYear)).ToListAsync();

            SalaryList = new List<ViewModel>();
            bool found = false;
            for (int i = 0; i < 12; i++)
            {
                found = false;
                foreach (var s in StaffSalary)
                {
                    if (s.Month == i + 1)
                    {
                        found = true;
                        int wdc = WeekDaysInMonth(s.Year, s.Month);
                        var ac = await _context.Attendance
                        .Where(a => a.ApplicationUserId == s.staffID && a.PunchDate.Value.Month == s.Month && a.PunchDate.Value.Year == s.Year && a.AttendanceStatusId == 2)
                        .OrderBy(a => a.PunchDate).ToListAsync();
                        //summary.net += v.BasicSalary / wdc * (wdc - ac.Count()) + v.Allowances + v.Bonus + v.AdvSalaryPlus - v.EPF - v.SocsoRm - v.EIS - v.Tax - v.AdvSalary;
                        decimal net = s.BasicSalary / wdc * (wdc - ac.Count()) + s.Allowances + s.Bonus + s.AdvSalaryPlus - s.EPF - s.SocsoRm - s.EIS - s.Tax - s.AdvSalary;
                        SalaryList.Add(new ViewModel { Id = s.salaryID, Month = monthArr[i], GenDate = s.DateCreated, Net = net});
                        continue;
                    }
                }
                if (!found)
                    SalaryList.Add(new ViewModel {Month = monthArr[i]});
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