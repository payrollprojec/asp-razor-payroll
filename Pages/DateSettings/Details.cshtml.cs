using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PayrollAppRazorPages.Data;
using PayrollAppRazorPages.Models;

namespace PayrollAppRazorPages.Pages.DateSettings
{
    public class DetailsModel : PageModel
    {
        private readonly PayrollAppRazorPages.Data.ApplicationDbContext _context;

        public DetailsModel(PayrollAppRazorPages.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Holiday Holiday { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Holiday = await _context.Holiday.FirstOrDefaultAsync(m => m.Id == id);

            if (Holiday == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
