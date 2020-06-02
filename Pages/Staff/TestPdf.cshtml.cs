using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jsreport.AspNetCore;
using jsreport.Types;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PayrollAppRazorPages.Pages.Staff
{
    [MiddlewareFilter(typeof(JsReportPipeline))]
    public class TestPdfModel : PageModel
    {
        public IActionResult OnGet()
        {
            HttpContext.JsReportFeature().Recipe(Recipe.ChromePdf);
            return Page();
        }
    }
}