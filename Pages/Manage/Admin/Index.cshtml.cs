﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PayrollAppRazorPages.Data;
using PayrollAppRazorPages.Models;

namespace PayrollAppRazorPages.Pages.Manage.Admin
{
    [Authorize(Roles = "superadmin")]
    public class IndexModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public IndexModel(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        [TempData]
        public string StatusMessage { get; set; }

        public IList<ApplicationUser> Users { get; set; }

        public async Task OnGetAsync()
        {
            Users = await _userManager.GetUsersInRoleAsync("admin");
        }
    }
}