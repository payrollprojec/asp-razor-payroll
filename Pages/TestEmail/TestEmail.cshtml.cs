using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PayrollAppRazorPages.Models;
using System.Net;
using System.Net.Mail;
using Microsoft.AspNetCore.Authorization;

namespace PayrollAppRazorPages.Pages.TestEmail
{
    [Authorize(Roles = "superadmin,admin")]
    public class TestEmailModel : PageModel
    {
        //public void OnGet()
        public void OnPost()
        {
            using (var message = new MailMessage())
            {
                message.To.Add(new MailAddress("mingching97@gmail.com", "To Mzz"));
                message.From = new MailAddress("formailingapp@gmail.com", "Payroll System");
                message.Subject = "Salary pdf";
                message.Body = "This is the salary slip.";
                message.IsBodyHtml = true;
                Attachment at = new Attachment("pdf/SalarySlip.pdf");
                message.Attachments.Add(at);

                using (var client = new SmtpClient("smtp.gmail.com"))
                {
                    client.Port = 587;
                    client.Credentials = new NetworkCredential("formailingapp@gmail.com", "abcd!@34");
                    client.EnableSsl = true;
                    client.Send(message);
                }
            }
        }
    }
}