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

namespace PayrollAppRazorPages.Pages.DateSettings
{
    [Authorize(Roles = "superadmin,admin,staff")]

    public class IndexModel : PageModel
    {
        private readonly PayrollAppRazorPages.Data.ApplicationDbContext _context;

        public IndexModel(PayrollAppRazorPages.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Holiday> Holiday { get;set; }

        public async Task OnGetAsync()
        {
            Holiday = await _context.Holiday.OrderBy(a => a.HolidayDate).ToListAsync();
        }
    }
}
