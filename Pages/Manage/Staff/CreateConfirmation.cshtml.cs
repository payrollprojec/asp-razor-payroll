using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PayrollAppRazorPages.Pages.Manage.Staff
{
    public class CreateConfirmationModel : PageModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public void OnGet(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            return RedirectToPage("./Index");
        }
    }
}