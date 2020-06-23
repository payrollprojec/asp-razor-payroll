using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PayrollAppRazorPages.Models;

namespace PayrollAppRazorPages.Pages.DateSettings
{
    [Authorize(Roles = "superadmin,admin")]
    public class CreateModel : PageModel
    {
        private readonly PayrollAppRazorPages.Data.ApplicationDbContext _context;

        public CreateModel(PayrollAppRazorPages.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        // For displaying all the holidays
        public IList<Holiday> HolidayList { get; set; }

        public async Task OnGetAsync()
        {
            HolidayList = await _context.Holiday.Where(a => a.HolidayDate.Value.Year == DateTime.Now.Year).OrderBy(a => a.HolidayDate).ToListAsync();
        }

        //For creating new holiday
        [BindProperty]
        public Holiday Holiday { get; set; }
        [TempData]
        public string StatusMessage { get; set; }


        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            HolidayList = await _context.Holiday.OrderBy(a => a.HolidayDate).ToListAsync();

            if (!ModelState.IsValid)
            {
                return Page();
            }

            var checkHoliday = await _context.Holiday.Where(a => a.HolidayDate == Holiday.HolidayDate && a.HolidayDes == Holiday.HolidayDes).SingleOrDefaultAsync();
            if (checkHoliday != null)
            {
                StatusMessage = "Error: Holiday already recorded";
                ModelState.AddModelError("dup", "Holiday already recorded");
                return Page();
            }

            _context.Holiday.Add(Holiday);
            await _context.SaveChangesAsync();
            StatusMessage = "Holiday has been added";

            return RedirectToPage("./Create");

        }
    }
}
