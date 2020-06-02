using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net;
using System.Net.Mail;

namespace PayrollAppRazorPages.Pages
{
    public class TestSendMailModel : PageModel
    {
        public void OnGet()
        {
            using (var message = new MailMessage())
            {
                message.To.Add(new MailAddress("lim.weiwen1997@gmail.com", "To Name"));
                message.From = new MailAddress("formailingapp@gmail.com", "From Name");
                message.Subject = "Subject";
                message.Body = "Body";
                message.IsBodyHtml = true;
                Attachment at = new Attachment("pdf/testu.pdf");
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