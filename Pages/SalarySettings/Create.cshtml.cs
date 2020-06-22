using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PayrollAppRazorPages.Data;
using PayrollAppRazorPages.Models;

namespace PayrollAppRazorPages.Pages.SalarySettings
{
    public class CreateModel : PageModel
    {
        private readonly PayrollAppRazorPages.Data.ApplicationDbContext _context;

        public CreateModel(PayrollAppRazorPages.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty(SupportsGet =true)]
        public string Type { get; set; }
        [TempData]
        public string StatusMessage { get; set; }
        public IActionResult OnGet()
        {
            SalaryItem = new SalaryItem()
            {
                IsDeduction = Type == "deduct" ? true : false
            };
            return Page();
        }

        [BindProperty]
        public SalaryItem SalaryItem { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.SalaryItem.Add(SalaryItem);
            await _context.SaveChangesAsync();
            StatusMessage = "Created New Record";
            return RedirectToPage("./Index");
        }
    }
}
