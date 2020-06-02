using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PayrollAppRazorPages.Data;
using PayrollAppRazorPages.Models;

namespace PayrollAppRazorPages
{
    public class CreateModel : PageModel
    {
        private readonly PayrollAppRazorPages.Data.ApplicationDbContext _context;

        public CreateModel(PayrollAppRazorPages.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public string UID { get; set; }

        public string usern { get; set; }

        public string pwd { get; set; }
        public IActionResult OnGet(string username, string password, string userid)
        {
            usern = username;
            pwd = password;
            UID = userid;
            System.Diagnostics.Debug.WriteLine("First Calling");
            System.Diagnostics.Debug.WriteLine(UID);
            return Page();
        }

        [BindProperty]
        public StaffSalary StaffSalary { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(string UUU, string PPP)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.StaffSalary.Add(StaffSalary);
            await _context.SaveChangesAsync();

            System.Diagnostics.Debug.WriteLine("Second Calling");
            System.Diagnostics.Debug.WriteLine(UUU);

            if (!(String.IsNullOrEmpty(UUU)))
            {
                return RedirectToPage("../Staff/CreateConfirmation", new { username = UUU, password = PPP });
            }
            else
            {
                return Page();
            }
            
        }
    }
}
