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
using jsreport.AspNetCore;
using jsreport.Types;
using jsreport.Local;
using jsreport.Binary;
using System.Net.Mail;
using System.Reflection.Metadata;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Drawing;
using System.Net;

namespace PayrollAppRazorPages.Pages.Manage.Salary
{
    [Authorize(Roles = "superadmin,admin")]
    [MiddlewareFilter(typeof(JsReportPipeline))]
    public class SaveSalaryPDFModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;

        private readonly PayrollAppRazorPages.Data.ApplicationDbContext _context;

        public SaveSalaryPDFModel(UserManager<ApplicationUser> userManager, PayrollAppRazorPages.Data.ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        public ApplicationUser applicationUser { get; set; }
        public StaffSalary StaffSalary { get; set; }
        public string SalaryDate { get; set;  }

        

         public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            StaffSalary = await _context.StaffSalary.FirstOrDefaultAsync(m => m.salaryID == id);
            applicationUser = await _userManager.Users.Include(u => u.StaffData).Where(u => u.Id == StaffSalary.staffID).SingleOrDefaultAsync();
            SalaryDate = DateTime.Parse(StaffSalary.Year + "-" + StaffSalary.Month + "-01").ToString("MMMM yyyy");

            if (StaffSalary == null)
            {
                return NotFound();
            }

            string pdfpath = string.Concat("./pdf/", SalaryDate, " ", applicationUser.FullName, " ", DateTime.Now.ToString("yyyyMMdd HHmmss"), ".pdf");
            HttpContext.JsReportFeature().Recipe(Recipe.ChromePdf);
            HttpContext.JsReportFeature().OnAfterRender((r) =>
            {
                using (var file = System.IO.File.Open(pdfpath, FileMode.Create))
               {
                   r.Content.CopyTo(file);
                }
                r.Content.Seek(0, SeekOrigin.Begin);
            });


            //var rs = new LocalReporting().UseBinary(JsReportBinary.GetBinary()).AsUtility().Create();
            //var report = await rs.RenderAsync(new RenderRequest()
            //{
            //    Template = new Template()
            //    {
            //        Recipe = Recipe.ChromePdf,
            //        Engine = Engine.None,
            //        Content = "Hello from pdf"
            //    }
            //});
            //using (var file = System.IO.File.Open(pdfpath, FileMode.Create))
            //{
            //    report.Content.CopyTo(file);
            //}
            //report.Content.Seek(0, SeekOrigin.Begin);


            return Page();
            //return RedirectToPage("./Index");

        }
    }
}
