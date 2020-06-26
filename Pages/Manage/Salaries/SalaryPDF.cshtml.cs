using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PayrollAppRazorPages.Models;
using SelectPdf;

namespace PayrollAppRazorPages.Pages.Manage.Salaries
{
    
    public class SalaryPDFModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;

        private readonly PayrollAppRazorPages.Data.ApplicationDbContext _context;

        public SalaryPDFModel(UserManager<ApplicationUser> userManager, PayrollAppRazorPages.Data.ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }
        [BindProperty(SupportsGet = true)]
        public string guid { get; set; }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            var applicationUser = await _userManager.GetUserAsync(User);

            if (applicationUser == null)
            {
                applicationUser = await _context.Users.Where(u => u.Id == guid).SingleOrDefaultAsync();

                if (applicationUser == null)
                    return Redirect("/Identity/Account/Login");

            }

            bool allowed = false;
            var roles = await _userManager.GetRolesAsync(applicationUser);
            if (roles[0] == "superadmin" || roles[0] == "admin")
            {
                allowed = true;
            }
            var StaffSalary = await _context.StaffSalary.FirstOrDefaultAsync(m => m.salaryID == id);
            if (StaffSalary == null) return NotFound();
            if (!allowed && StaffSalary.staffID != applicationUser.Id)
            {
                return Redirect("/Identity/Account/Login");
            }
            HtmlToPdf converter = new HtmlToPdf();
            PdfDocument doc = converter.ConvertUrl("https://localhost:44379/Manage/Salaries/GetSalaryForPdf?id=" + id + "&guid=" + applicationUser.Id);
            //PdfDocument doc = converter.ConvertUrl("https://localhost:44379/Manage/Salaries/GetSalaryForPdf?id=69&guid=9be835d3-4326-4e4f-82ee-c1e487d139fc");
            MemoryStream pdfStream = new MemoryStream();


            doc.Save(pdfStream);
            pdfStream.Position = 0;
            doc.Close();
            return File(pdfStream.ToArray(), "application/pdf");
        }
    }
}