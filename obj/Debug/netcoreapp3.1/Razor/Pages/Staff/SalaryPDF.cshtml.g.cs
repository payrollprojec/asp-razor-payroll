#pragma checksum "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08e017cf171af1845a420aefd0d96df78a765b53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PayrollAppRazorPages.Pages.Staff.Pages_Staff_SalaryPDF), @"mvc.1.0.razor-page", @"/Pages/Staff/SalaryPDF.cshtml")]
namespace PayrollAppRazorPages.Pages.Staff
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\_ViewImports.cshtml"
using PayrollAppRazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\_ViewImports.cshtml"
using PayrollAppRazorPages.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08e017cf171af1845a420aefd0d96df78a765b53", @"/Pages/Staff/SalaryPDF.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"861da5bb15acd1d78ca3a5927656d550f7c86cd6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Staff_SalaryPDF : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
  
    ViewData["Title"] = "SalaryPDF";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<br />
<hr style=""height:2px; color:black; background-color:black;"" />
<br />
<h1 style=""text-align: center;"">V3X Malaysia Sdn. Bhd.</h1>
<p style=""text-align: center;"">79A, Jalan Pulai 23, Taman Pulai Utama,</p>
<p style=""text-align: center;"">81300 Skudai, Johor, Malaysia</p>
<br />
<hr style=""height:2px; color:black; background-color:black;"" />
<br />

<style>
    .slip {
        font-family: Consolas, monospace;
        border: solid 1px;
        padding: 20px;
    }

    span.text-danger {
        display: block;
    }
</style>
<div class=""slip container-fluid"">
    <div class=""row"">
        <div class=""col""><h4>PAYSLIP FOR ");
#nullable restore
#line 31 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
                                    Write(Model.SelectedDate.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></div>\r\n        <div class=\"col align-self-center text-right\">\r\n            <h4 class=\"small\">Generated on ");
#nullable restore
#line 33 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
                                      Write(Model.StaffSalary.DateCreated.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row border-bottom border-top\">\r\n        <div class=\"col border-right\">\r\n\r\n            <br /><b>Employee Details</b><br />\r\n\r\n            ");
#nullable restore
#line 42 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
       Write(Html.DisplayNameFor(model => model.applicationUser.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;&nbsp;&nbsp;&nbsp;:\r\n            ");
#nullable restore
#line 43 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
       Write(Html.DisplayFor(model => model.applicationUser.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n\r\n            ");
#nullable restore
#line 46 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
       Write(Html.DisplayNameFor(model => model.applicationUser.ICNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;&nbsp;:\r\n            ");
#nullable restore
#line 47 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
       Write(Html.DisplayFor(model => model.applicationUser.ICNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n\r\n            ");
#nullable restore
#line 50 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
       Write(Html.DisplayNameFor(model => model.applicationUser.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;&nbsp;&nbsp;:\r\n            ");
#nullable restore
#line 51 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
       Write(Html.DisplayFor(model => model.applicationUser.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n            ");
#nullable restore
#line 53 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
       Write(Html.DisplayNameFor(model => model.applicationUser.StaffData.EPFNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;&nbsp;:\r\n            ");
#nullable restore
#line 54 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
       Write(Html.DisplayFor(model => model.applicationUser.StaffData.EPFNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n\r\n            ");
#nullable restore
#line 57 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
       Write(Html.DisplayNameFor(model => model.applicationUser.StaffData.SocsoNo));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n            ");
#nullable restore
#line 58 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
       Write(Html.DisplayFor(model => model.applicationUser.StaffData.SocsoNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n            ");
#nullable restore
#line 60 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
       Write(Html.DisplayNameFor(model => model.applicationUser.StaffData.TaxNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;&nbsp;:\r\n            ");
#nullable restore
#line 61 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
       Write(Html.DisplayFor(model => model.applicationUser.StaffData.TaxNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n        </div>\r\n        <div class=\"col\">\r\n");
#nullable restore
#line 65 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
              
                Dictionary<string, int> dict = new Dictionary<string, int>();
                dict.Add("Present", 0);
                dict.Add("Absent", 0);
                dict.Add("Leave", 0);
                dict.Add("Sick", 0);

                foreach (var item in Model.UserAttendance)
                {
                    dict[item.AttendanceStatus.Status] += 1;
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <br /><b>Attendance Record</b>\r\n            <br />\r\n            Absent: ");
#nullable restore
#line 79 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
               Write(dict["Absent"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n            Leave : ");
#nullable restore
#line 81 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
               Write(dict["Leave"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n            Sick &nbsp;: ");
#nullable restore
#line 83 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
                    Write(dict["Sick"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n\r\n        <div class=\"col border-right\">\r\n            <br /><b>Earning</b>\r\n            <div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08e017cf171af1845a420aefd0d96df78a765b5310587", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 91 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.StaffSalary.BasicSalary);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("&nbsp;&nbsp;&nbsp;: RM\r\n                ");
#nullable restore
#line 92 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
           Write(Html.DisplayFor(model => model.StaffSalary.BasicSalary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08e017cf171af1845a420aefd0d96df78a765b5312417", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 95 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.StaffSalary.Allowances);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(": RM\r\n                ");
#nullable restore
#line 96 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
           Write(Html.DisplayFor(model => model.StaffSalary.Allowances));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08e017cf171af1845a420aefd0d96df78a765b5314227", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 99 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.StaffSalary.Bonus);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;: RM\r\n                ");
#nullable restore
#line 100 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
           Write(Html.DisplayFor(model => model.StaffSalary.Bonus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08e017cf171af1845a420aefd0d96df78a765b5316088", async() => {
                WriteLiteral("Adv. Salary&nbsp;&nbsp;&nbsp;&nbsp;: RM");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 103 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.StaffSalary.AdvSalary);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
#nullable restore
#line 104 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
           Write(Html.DisplayFor(model => model.StaffSalary.AdvSalaryPlus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"col\">\r\n            <br /><b>Deduction</b>\r\n            <div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08e017cf171af1845a420aefd0d96df78a765b5318059", async() => {
                WriteLiteral("EPF&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;: RM");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 110 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.StaffSalary.EPF);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
#nullable restore
#line 111 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
           Write(Html.DisplayFor(model => model.StaffSalary.EPF));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08e017cf171af1845a420aefd0d96df78a765b5319943", async() => {
                WriteLiteral("SOCSO&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;: RM");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 114 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.StaffSalary.SocsoRm);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
#nullable restore
#line 115 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
           Write(Html.DisplayFor(model => model.StaffSalary.SocsoRm));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08e017cf171af1845a420aefd0d96df78a765b5321825", async() => {
                WriteLiteral("EIS&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;: RM");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 118 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.StaffSalary.EIS);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
#nullable restore
#line 119 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
           Write(Html.DisplayFor(model => model.StaffSalary.EIS));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08e017cf171af1845a420aefd0d96df78a765b5323709", async() => {
                WriteLiteral("TAX&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;: RM");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 122 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.StaffSalary.Tax);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
#nullable restore
#line 123 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
           Write(Html.DisplayFor(model => model.StaffSalary.Tax));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08e017cf171af1845a420aefd0d96df78a765b5325593", async() => {
                WriteLiteral("Adv. Salary: RM");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 126 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.StaffSalary.AdvSalary);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
#nullable restore
#line 127 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
           Write(Html.DisplayFor(model => model.StaffSalary.AdvSalary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n");
#nullable restore
#line 130 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
                  
                    var absent = Model.StaffSalary.BasicSalary / Model.WeekdaysCount * dict["Absent"];
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label>Absent&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;: RM</label>\r\n                <span>");
#nullable restore
#line 134 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
                 Write(absent.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> (");
#nullable restore
#line 134 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
                                                  Write(dict["Absent"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" days)\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"row border-bottom align-items-end\">\r\n\r\n        <div class=\"col border-right\">\r\n");
#nullable restore
#line 141 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
              
                var totalEarn = Model.StaffSalary.BasicSalary + Model.StaffSalary.Allowances + Model.StaffSalary.Bonus + Model.StaffSalary.AdvSalaryPlus;
                var totalDeduct = Model.StaffSalary.EPF + Model.StaffSalary.SocsoRm + Model.StaffSalary.EIS + Model.StaffSalary.Tax + Model.StaffSalary.AdvSalary + absent;
                var net = totalEarn - totalDeduct;
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            Total Earning: RM ");
#nullable restore
#line 146 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
                         Write(totalEarn.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n            Net Pay&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;: RM ");
#nullable restore
#line 148 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
                                                       Write(net.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n        </div>\r\n        <div class=\"col\">\r\n            Total Deduction: RM ");
#nullable restore
#line 152 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
                           Write(totalDeduct.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n    <div class=\"row border-bottom\">\r\n        <div class=\"col border-right\">\r\n            <br />\r\n            <b>Employer Contribution</b>\r\n            <div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08e017cf171af1845a420aefd0d96df78a765b5330446", async() => {
                WriteLiteral("EPF&nbsp;&nbsp;: RM");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 161 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.StaffSalary.EREPF);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
#nullable restore
#line 162 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
           Write(Html.DisplayFor(model => model.StaffSalary.EREPF));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08e017cf171af1845a420aefd0d96df78a765b5332298", async() => {
                WriteLiteral("SOCSO: RM");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 165 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.StaffSalary.ERSocsoRm);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
#nullable restore
#line 166 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
           Write(Html.DisplayFor(model => model.StaffSalary.ERSocsoRm));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08e017cf171af1845a420aefd0d96df78a765b5334148", async() => {
                WriteLiteral("EIS&nbsp;&nbsp;: RM");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 169 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.StaffSalary.EREIS);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
#nullable restore
#line 170 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
           Write(Html.DisplayFor(model => model.StaffSalary.EREIS));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"col\">\r\n            <br />\r\n            <b>Year Summary (inc ");
#nullable restore
#line 175 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
                            Write(Model.SelectedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</b><br />\r\n            Net Pay&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;: RM ");
#nullable restore
#line 176 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
                                                                   Write(Html.DisplayFor(model => model.summary.net));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n            E\'E / E\'R EPF &nbsp;: RM ");
#nullable restore
#line 177 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
                                Write(Html.DisplayFor(model => model.summary.epf));

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 177 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
                                                                               Write(Html.DisplayFor(model => model.summary.erepf));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n            E\'E / E\'R SOCSO: RM ");
#nullable restore
#line 178 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
                           Write(Html.DisplayFor(model => model.summary.socso));

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 178 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
                                                                            Write(Html.DisplayFor(model => model.summary.ersocso));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n            E\'E / E\'R EIS &nbsp;: RM ");
#nullable restore
#line 179 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
                                Write(Html.DisplayFor(model => model.summary.eis));

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 179 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
                                                                               Write(Html.DisplayFor(model => model.summary.ereis));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n            TAX&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;: RM ");
#nullable restore
#line 180 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\SalaryPDF.cshtml"
                                                                                       Write(Model.summary.tax);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        </div>\r\n    </div>\r\n    <br />\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PayrollAppRazorPages.Pages.Staff.SalaryPDFModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PayrollAppRazorPages.Pages.Staff.SalaryPDFModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PayrollAppRazorPages.Pages.Staff.SalaryPDFModel>)PageContext?.ViewData;
        public PayrollAppRazorPages.Pages.Staff.SalaryPDFModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
