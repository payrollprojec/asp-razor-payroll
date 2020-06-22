using System;
using System.Collections.Generic;
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


namespace PayrollAppRazorPages.Pages.Manage.Salaries
{
    [Authorize(Roles = "superadmin,admin")]
    public class SendEmailModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;
        //private readonly IRazorViewEngine _viewEngine;
        //private readonly ITempDataProvider _tempDataProvider;
        //private readonly IServiceProvider _serviceProvider;
        [TempData]
        public string StatusMessage { get; set; }
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
        public string SalaryDate { get; set; }
        public List<StaffSalaryExtra> StaffSalaryExtras { get; private set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            StaffSalary = await _context.StaffSalary.FirstOrDefaultAsync(m => m.salaryID == id);

            if (StaffSalary == null)
            {
                return NotFound();
            }

            applicationUser = await _userManager.Users.Include(u => u.StaffData).Where(u => u.Id == StaffSalary.staffID).SingleOrDefaultAsync();
            SalaryDate = DateTime.Parse(StaffSalary.Year + "-" + StaffSalary.Month + "-01").ToString("MMMM yyyy");
            return Page();
            //return await OnPostAsync(id);
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

            int wdc = _context.WeekDaysInMonth(StaffSalary.Year, StaffSalary.Month);
            var ac = await _context.Attendance.Include(a => a.AttendanceStatus)
            .Where(a => a.ApplicationUserId == StaffSalary.staffID && a.PunchDate.Value.Month == StaffSalary.Month && a.PunchDate.Value.Year == StaffSalary.Year && a.AttendanceStatus.Status == "Absent")
            .OrderBy(a => a.PunchDate).ToListAsync();
            // Save Template
            StaffSalaryExtras = await _context.StaffSalaryExtra.Include(s => s.SalaryItem).Where(s => s.StaffSalaryId == StaffSalary.salaryID).ToListAsync();
            decimal extraEarns = 0;
            decimal extraDucts = 0;
            string extraearn = "";
            string extraduct = "";
            foreach (var j in StaffSalaryExtras)
            {
                if (j.SalaryItem.IsDeduction == false)
                {
                    extraEarns += j.Amount;
                    extraearn += "<b>" + j.SalaryItem.Name + ": </b>" + j.Amount + "<br>";
                }
                else
                {
                    extraDucts += j.Amount;
                    extraduct += "<b>" + j.SalaryItem.Name + ": </b>" + j.Amount + "<br>";
                }
            }
            // Send Email 
            string body = "Dear " + applicationUser.FullName + ", this is the summary of your salary  in " + SalaryDate + ".<br><br><hr>" +
                            "<h3> Salary Slip in " + SalaryDate + "</h3>" +
                            "<hr><br>" +
                            "<table cellspacing='0' cellpadding='10' border='1'>" +
                            "<tr><th>Earning (RM)</th><th>Deduction (RM)</th></tr>" +
                            "<tr>" +
                            "<td>" +
                            "<b>Basic Salary: </b>" + StaffSalary.BasicSalary + "<br>" +
                            "<b>Allowance: </b>" + StaffSalary.Allowances + "<br>" +
                            "<b>Bonus: </b>" + StaffSalary.Bonus + "<br>" +
                            "<b>Adv. Salary: </b>" + StaffSalary.AdvSalaryPlus + "<br><br>" +
                            extraearn +
                            "</td>" +
                            "<td>" +
                            "<b>EPF: </b>" + StaffSalary.EPF + "<br>" +
                            "<b>SOCSO: </b>" + StaffSalary.SocsoRm + "<br>" +
                            "<b>EIS: </b>" + StaffSalary.EIS + "<br>" +
                            "<b>TAX: </b>" + StaffSalary.Tax + "<br>" +
                            "<b>Adv. Salary: </b>" + StaffSalary.AdvSalary + "<br>" +
                            //"<b>Absent: </b>" + (StaffSalary.BasicSalary / wdc * ac.Count()).ToString("0.00") + "<br><br>" +
                            "<b>Absent: </b>" + StaffSalary.Absent + " (" + ac.Count() + ") day" + "<br><br>" +
                            extraduct +
                            "</td>" +
                            "</tr>" +

                            //"<tr>" +
                            //"<td>" +
                            //"<b>Net Pay: </b>RM " + (StaffSalary.BasicSalary - StaffSalary.Absent + StaffSalary.Allowances + StaffSalary.Bonus + StaffSalary.AdvSalaryPlus - StaffSalary.EPF - StaffSalary.SocsoRm - StaffSalary.EIS - StaffSalary.Tax - StaffSalary.AdvSalary).ToString("0.00") + "<br>" +
                            //"</td>" +
                            //"</tr>" +

                            "<tr>" +
                            "<td>" +
                            "<b>Total Earnings: " + (StaffSalary.BasicSalary + extraEarns + StaffSalary.Allowances + StaffSalary.Bonus + StaffSalary.AdvSalaryPlus) + "<br>" +
                            "</td>" +
                            "<td>" +
                            "<b>Total Deductions: " + (StaffSalary.Absent + extraDucts + StaffSalary.EPF + StaffSalary.SocsoRm + StaffSalary.EIS + StaffSalary.Tax + StaffSalary.AdvSalary).ToString("0.00") + "<br>" +
                            "</td>" +
                            "</tr>" +

                            "<tr>" +
                            "<td colspan='2'>" +
                            "<b>Net Pay: </b>RM " + (StaffSalary.BasicSalary + extraEarns - extraDucts - StaffSalary.Absent + StaffSalary.Allowances + StaffSalary.Bonus + StaffSalary.AdvSalaryPlus - StaffSalary.EPF - StaffSalary.SocsoRm - StaffSalary.EIS - StaffSalary.Tax - StaffSalary.AdvSalary).ToString("0.00") + "<br>" +
                            "</td>" +
                            "</tr>" +
                            "<tr>" +
                            "<td colspan='2'>" +
                            "For more information, please visit: <br><b>" +
                            "https://localhost:44379/Staff/SalaryDetails/" + id + "?key=" + applicationUser.Id + "</b><br>" +
                            "Sent on - " + DateTime.Now.ToString("dddd, dd MMMM yyyy h:mm:ss tt") + // insert different string so gmail wont trim email content
                            "</td>" +
                            "</tr></table>";


            using (var message = new MailMessage())
            {
                message.To.Add(new MailAddress(applicationUser.Email, applicationUser.Email));
                message.From = new MailAddress("formailingapp@gmail.com", "V3X Payroll System");
                message.Subject = "Salary Slip in " + SalaryDate;
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
            StatusMessage = "Salary Slip Emailed to <" + applicationUser.Email + ">";
            //return RedirectToPage("./SendEmailConfirmation", new { name = applicationUser.FullName, email = applicationUser.Email, StaffSalary.Month, StaffSalary.Year });
            return RedirectToPage("./Index", new { SelectedMonth = StaffSalary.Month, SelectedYear = StaffSalary.Year });

        }


    }

}
