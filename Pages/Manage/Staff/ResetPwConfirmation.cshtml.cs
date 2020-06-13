using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PayrollAppRazorPages.Pages.Manage.Staff
{
    public class ResetPwConfirmationModel : PageModel
    {
        [BindProperty(SupportsGet =true)]
        public string Username { get; set; }
        [BindProperty(SupportsGet =true)]
        public string Password { get; set; }
        public void OnGet()
        {

        }
    }
}