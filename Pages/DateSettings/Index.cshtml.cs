using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PayrollAppRazorPages.Data;
using PayrollAppRazorPages.Models;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PayrollAppRazorPages.Pages.DateSettings
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly PayrollAppRazorPages.Data.ApplicationDbContext _context;
        public IndexModel(PayrollAppRazorPages.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<SelectListItem> Months { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SelectedMonth { get; set; }
        public SelectList Years { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SelectedYear { get; set; }

        public IList<Holiday> Holiday { get;set; }

        public async Task OnGetAsync()
        {
            // Deal with filter by date
            string[] monthArr = new string[] { "All Month",  "January", "February", "March", "April", "May", "June",
                "July", "August", "September", "October", "November", "December" };
            Months = new List<SelectListItem>();
            for (int i = 0; i < 13; i++)
            {
                Months.Add(new SelectListItem(monthArr[i], (i).ToString()));
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

            // whenever click in holiday index - both month & year are not selected
            if (string.IsNullOrEmpty(SelectedYear) && string.IsNullOrEmpty(SelectedMonth))
            {
                SelectedMonth = "0";
                SelectedYear = DateTime.Now.Year.ToString();
                Holiday = await _context.Holiday
                     .Where(a => a.HolidayDate.Value.Year == int.Parse(SelectedYear))
                    .OrderBy(a => a.HolidayDate).ToListAsync();
            }
            // Select "All month" and had chosen a year
            else if (!string.IsNullOrEmpty(SelectedMonth) && SelectedMonth == "0" && !string.IsNullOrEmpty(SelectedYear))
            {
                Holiday = await _context.Holiday
                     .Where(a => a.HolidayDate.Value.Year == int.Parse(SelectedYear))
                    .OrderBy(a => a.HolidayDate).ToListAsync();
            }
            else if (!string.IsNullOrEmpty(SelectedMonth) && SelectedMonth != "0" && !string.IsNullOrEmpty(SelectedYear))
            {
                Holiday = await _context.Holiday
                  .Where(a => a.HolidayDate.Value.Year == int.Parse(SelectedYear) && a.HolidayDate.Value.Month == int.Parse(SelectedMonth))
                  .OrderBy(a => a.HolidayDate)
                  .ToListAsync();
            }
            // user hiao go delete month or year from url, reset to first visit
            else
            {
                if (string.IsNullOrEmpty(SelectedMonth))
                    SelectedMonth = "0";
                if (string.IsNullOrEmpty(SelectedYear))
                    SelectedYear = DateTime.Now.Year.ToString();

                Holiday = await _context.Holiday
                   .Where(a => a.HolidayDate.Value.Year == int.Parse(SelectedYear))
                   .OrderBy(a => a.HolidayDate)
                   .ToListAsync();
            }
        }
    }
}
