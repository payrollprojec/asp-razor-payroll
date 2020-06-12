﻿using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PayrollAppRazorPages.Data;
using PayrollAppRazorPages.Models;
using jsreport.AspNetCore;
using jsreport.Types;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorEngine;
using RazorEngine.Templating;
using System.Dynamic;

namespace PayrollAppRazorPages.Pages.Manage.Salary
{
    [Authorize(Roles = "superadmin,admin")]
    public class SendEmailModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;
        //private readonly IRazorViewEngine _viewEngine;
        //private readonly ITempDataProvider _tempDataProvider;
        //private readonly IServiceProvider _serviceProvider;

        public SendEmailModel(UserManager<ApplicationUser> userManager, ApplicationDbContext context
            //, IRazorViewEngine viewEngine,
            //ITempDataProvider tempDataProvider,
            //IServiceProvider serviceProvider
            )
        {
            _userManager = userManager;
            _context = context;
            //_viewEngine = viewEngine;
            //_tempDataProvider = tempDataProvider;
            //_serviceProvider = serviceProvider;
        }

        [BindProperty]
        public StaffSalary StaffSalary { get; set; }
        public ApplicationUser applicationUser { get; set; }
        public string SalaryDate{ get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            //if (id == null)
            //{
            //    return NotFound();
            //}
            //StaffSalary = await _context.StaffSalary.FirstOrDefaultAsync(m => m.salaryID == id);

            //if (StaffSalary == null)
            //{
            //    return NotFound();
            //}

            //applicationUser = await _userManager.Users.Include(u => u.StaffData).Where(u => u.Id == StaffSalary.staffID).SingleOrDefaultAsync();
            //SalaryDate = DateTime.Parse(StaffSalary.Year + "-" + StaffSalary.Month + "-01").ToString("MMMM yyyy");
            //return Page();
            return await OnPostAsync(id);
        }
        //public class Person
        //{
        //    public string name { get; set; }
        //    public int age { get; set; }
        //}

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            StaffSalary = await _context.StaffSalary.FirstOrDefaultAsync(m => m.salaryID == id);
            if (StaffSalary == null)
            {
                return NotFound();
            }
            applicationUser = await _userManager.Users.Include(u => u.StaffData).Where(u => u.Id == StaffSalary.staffID).SingleOrDefaultAsync();
            SalaryDate = DateTime.Parse(StaffSalary.Year + "-" + StaffSalary.Month + "-01").ToString("MMMM yyyy");


            // Save Template

            // Send Email 
            string body = "Dear " + applicationUser.FullName + ", this is the summary of your salary  in " + SalaryDate + ".<br><br><hr>" +
                            "<h3> Salary Slip in " + SalaryDate + "</h3>" + 
                            "<hr><br>" +
                            "<table>" +
                            "<tr>" +
                            "<td><b>Basic Salary: </b></td>" +
                            "<td>" + StaffSalary.BasicSalary +"</td>" +
                            "</tr>" +
                            "<tr>" +
                             "<td><b>Bonus: </b></td>" +
                             "<td>" + StaffSalary.Bonus + "</td>" +
                            "</tr>" +
                            "<tr>" +
                            "<td><b>Allowances: </b></td>" +
                            "<td>" + StaffSalary.Allowances + "</td>" +
                            "</tr>" +
                            "<tr>" +
                            "<tr>" +
                            "<td><b>Allowances: </b></td>" +
                            "<td>" + StaffSalary.AdvSalaryPlus + "</td>" +
                            "</tr>" +
                            "<tr>" +
                            "<td><b>EPF: </b></td>" +
                            "<td>" + StaffSalary.EPF + "</td>" +
                            "</tr>" +
                            "<tr>" +
                            "<td><b>Socso: </b></td>" +
                            "<td>" + StaffSalary.SocsoRm + "</td>" +
                            "</tr>" +
                             "<tr>" +
                            "<td><b>Advanced Salary: </b></td>" +
                            "<td>" + StaffSalary.AdvSalary + "</td>" +
                            "</tr>" +
                             "<tr>" +
                            "<td><b>Gross Salary: </b></td>" +
                            //"<td>" + StaffSalary.GrossSalary + "</td>" +
                            "</tr>" +
                "</table><br> <hr> <br>" +
                "For more information, please visit: <br><b>" +
                "https://localhost:44379/Staff/SalaryDetails/"+ id+ "?key="+ applicationUser.Id + "</b>";


              using (var message = new MailMessage())
            {
                message.To.Add(new MailAddress(applicationUser.Email, applicationUser.Email));
                message.From = new MailAddress("formailingapp@gmail.com", "V3X Payroll System");
                message.Subject = "Salary Slip pdf";
                message.IsBodyHtml = true;

                message.Body = body;
                //Attachment at = new Attachment("pdf/SalarySlip.pdf");
                //message.Attachments.Add(at);

                using (var client = new SmtpClient("smtp.gmail.com"))
                {
                    client.Port = 587;
                    client.Credentials = new NetworkCredential("formailingapp@gmail.com", "abcd!@34");
                    client.EnableSsl = true;
                    client.Send(message);
                }
            }

            StaffSalary.MailNum += 1;
            _context.Attach(StaffSalary).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return RedirectToPage("./SendEmailConfirmation", new { name = applicationUser.FullName, email = applicationUser.Email });
        }


    }
    
}
