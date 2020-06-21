using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PayrollAppRazorPages.Data;
using PayrollAppRazorPages.Models;

namespace PayrollAppRazorPages.Pages.SalarySettings
{
    public class IndexModel : PageModel
    {
        private readonly PayrollAppRazorPages.Data.ApplicationDbContext _context;
        [TempData]
        public string StatusMessage { get; set; }
        public IndexModel(PayrollAppRazorPages.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<SalaryItem> SalaryItem { get;set; }

        public async Task OnGetAsync()
        {
            SalaryItem = await _context.SalaryItem.ToListAsync();
        }
    }
}
