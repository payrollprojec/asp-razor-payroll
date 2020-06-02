using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PayrollAppRazorPages.Models;
using Syncfusion.HtmlConverter;
using Syncfusion.Pdf;
using Microsoft.AspNetCore.Hosting;
using System.Web.Mvc;
using FileResult = System.Web.Mvc.FileResult;
using jsreport.AspNetCore;
using jsreport.Types;

namespace PayrollAppRazorPages
{
    [MiddlewareFilter(typeof(JsReportPipeline))]
    public class SalaryPDFModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;

        private readonly PayrollAppRazorPages.Data.ApplicationDbContext _context;

        public SalaryPDFModel(UserManager<ApplicationUser> userManager, PayrollAppRazorPages.Data.ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        public IList<ApplicationUser> Staff { get; set; }

        public StaffSalary StaffSalary { get; set; }

        //public async Task<IActionResult> OnGetAsync(int? id)
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Staff = await _userManager.GetUsersInRoleAsync("staff");

            StaffSalary = await _context.StaffSalary.FirstOrDefaultAsync(m => m.salaryID == id);

            if (StaffSalary == null)
            {
                return NotFound();
            }

            HttpContext.JsReportFeature().Recipe(Recipe.ChromePdf);
            return Page();
        }
    }
}
