#pragma checksum "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6969e8e1cbdb00e9adb4d4184023d6ae0aa9830e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PayrollAppRazorPages.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace PayrollAppRazorPages.Pages
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6969e8e1cbdb00e9adb4d4184023d6ae0aa9830e", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"861da5bb15acd1d78ca3a5927656d550f7c86cd6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Manage/Admin/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Manage/Staff/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Manage/Attendances/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Manage/Salaries/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./SalarySettings/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./DateSettings/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Staff/Attendance", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Staff/Salary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.12.0-2/css/all.min.css"" integrity=""sha256-46r060N2LrChLLb5zowXQ72/iKKNiw/lAmygmHExk/o="" crossorigin=""anonymous"" />

<style>
    .btn {
        padding: 0;
    }

    .card-footer {
        padding: 10px;
    }
</style>

<div class=""text-center"">
");
#nullable restore
#line 20 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Index.cshtml"
     if (User.IsInRole("superadmin"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>Superadmin Dashboard</h3><br />\r\n");
#nullable restore
#line 23 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Index.cshtml"
    }
    else if (User.IsInRole("admin"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>Admin Dashboard</h3><br />\r\n");
#nullable restore
#line 27 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Index.cshtml"

    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>Staff Dashboard</h3><br />\r\n");
#nullable restore
#line 32 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 35 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Index.cshtml"
     if (User.IsInRole("superadmin") || User.IsInRole("admin"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card-deck text-left  \">\r\n\r\n");
#nullable restore
#line 39 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Index.cshtml"
         if (User.IsInRole("superadmin"))
        {
        //manage admin card #0173b9

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card text-white\" style=\"background-color:steelblue;\">\r\n            <div class=\"card-body\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-9\">\r\n                        <h1>");
#nullable restore
#line 46 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Index.cshtml"
                       Write(Model.AdminNum);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h1>
                    </div>
                    <div class=""col"">
                        <h1 class=""text-right""><i class=""fas fa-user-tie""></i></h1>
                    </div>
                </div>
                Admin(s)
            </div>
            <div class=""card-footer"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6969e8e1cbdb00e9adb4d4184023d6ae0aa9830e9065", async() => {
                WriteLiteral("Manage Admin  <i class=\"fas fa-arrow-circle-right\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n");
#nullable restore
#line 59 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Index.cshtml"
        }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card text-left text-white\" style=\"background-color:lightcoral ;\">\r\n            <div class=\"card-body\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-9\">\r\n                        <h1>");
#nullable restore
#line 66 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Index.cshtml"
                       Write(Model.StaffNum);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                    </div>
                    <div class=""col"">
                        <h1 class=""text-right""><i class=""fas fa-users""></i> </h1>
                    </div>
                </div>
                Staff
            </div>
            <div class=""card-footer"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6969e8e1cbdb00e9adb4d4184023d6ae0aa9830e11401", async() => {
                WriteLiteral("Manage Staff  <i class=\"fas fa-arrow-circle-right\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n");
            WriteLiteral("        <div class=\"card text-white text-left\" style=\"background-color:darkorange\">\r\n            <div class=\"card-body \">\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-9\">\r\n                        <h1 style=\"display:inline;\">");
#nullable restore
#line 84 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Index.cshtml"
                                               Write(Model.AttendanceCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        <p style=\"display:inline;\">/ ");
#nullable restore
#line 85 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Index.cshtml"
                                                Write(Model.StaffNum);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                    <div class=""col"">
                        <h1 class=""text-right""><i class=""fas fa-clipboard-list""></i> </h1>
                    </div>
                </div>
                Today's Attandance Record
            </div>
            <div class=""card-footer"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6969e8e1cbdb00e9adb4d4184023d6ae0aa9830e13968", async() => {
                WriteLiteral("Staff Attendance  <i class=\"fas fa-arrow-circle-right\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 97 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Index.cshtml"
         if (User.IsInRole("admin"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col\"></div>\r\n");
#nullable restore
#line 100 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div><br />\r\n    <div class=\"card-deck text-left \">\r\n");
            WriteLiteral(@"        <div class=""card text-white bg-success "">
            <div class=""card-body "">
                <div class=""row"">
                    <div class=""col-md-8 align-items-end"">
                        <h3>Year Summary</h3>
                    </div>
                    <div class=""col"">
                        <h1 class=""text-right""><i class=""fas fa-file-invoice-dollar""></i></h1>
                    </div>
                </div>
                Total Net Pay: RM ");
#nullable restore
#line 114 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Index.cshtml"
                             Write(Html.DisplayFor(model => model.summary.net));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"card-footer text-left\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6969e8e1cbdb00e9adb4d4184023d6ae0aa9830e16724", async() => {
                WriteLiteral("Manage Salary  <i class=\"fas fa-arrow-circle-right\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n");
            WriteLiteral(@"        <div class=""card text-white"" style=""background-color:#76c82f;"">
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col-md-9"">
                    </div>
                    <div class=""col"">
                        <h1 class=""text-right""><i class=""fas  fa-sliders-h  fa-fw""></i></h1>
                    </div>
                </div>
            </div>
            <div class=""card-footer"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6969e8e1cbdb00e9adb4d4184023d6ae0aa9830e18584", async() => {
                WriteLiteral("Salary Setting <i class=\"fas fa-arrow-circle-right\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
            WriteLiteral(@"        <div class=""card text-white bg-warning"">
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col-md-9"">
                        <h3>Coming Holiday</h3>
                    </div>
                    <div class=""col"">
                        <h1 class=""text-right""><i class=""fas fa-calendar-day fa-fw""></i></h1>
                    </div>
                </div>
                ");
#nullable restore
#line 149 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Index.cshtml"
           Write(Model.ComingHoliday);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"card-footer\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6969e8e1cbdb00e9adb4d4184023d6ae0aa9830e20716", async() => {
                WriteLiteral("Holiday Setting <i class=\"fas fa-arrow-circle-right\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 156 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 157 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Index.cshtml"
     if (User.IsInRole("staff"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card-deck\">\r\n");
            WriteLiteral("        <div class=\"card text-white bg-info\">\r\n            <div class=\"card-body\">\r\n                <h1 style=\"display:inline;\"> ");
#nullable restore
#line 163 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Index.cshtml"
                                        Write(Model.TodayDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\r\n");
            WriteLiteral("\r\n                <p>");
#nullable restore
#line 166 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Index.cshtml"
              Write(Model.RecordStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"card-footer\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6969e8e1cbdb00e9adb4d4184023d6ae0aa9830e23288", async() => {
                WriteLiteral("Check Attendance <i class=\"fas fa-arrow-circle-right\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
            WriteLiteral(@"        <div class=""card bg-success text-white"">
            <div class=""card-body row"">
                <div class=""col-md-8 text-left"">
                    <h4>Year Summary</h4>
                    <div class=""row"">
                        <div class=""col-5"">Net Pay</div>
                        <div class=""col"">: RM ");
#nullable restore
#line 179 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Index.cshtml"
                                         Write(Model.summary.net.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"col-5\">E\'E / E\'R EPF</div>\r\n                        <div class=\"col\">: RM ");
#nullable restore
#line 183 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Index.cshtml"
                                         Write(Model.summary.epf.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 183 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Index.cshtml"
                                                                               Write(Model.summary.erepf.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"col-5\">E\'E / E\'R SOCSO</div>\r\n                        <div class=\"col\">: RM ");
#nullable restore
#line 187 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Index.cshtml"
                                         Write(Model.summary.socso.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 187 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Index.cshtml"
                                                                                 Write(Model.summary.ersocso.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"col-5\">E\'E / E\'R EIS</div>\r\n                        <div class=\"col\">: RM ");
#nullable restore
#line 191 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Index.cshtml"
                                         Write(Model.summary.eis.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 191 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Index.cshtml"
                                                                               Write(Model.summary.ereis.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"col-5\">TAX</div>\r\n                        <div class=\"col\">: RM ");
#nullable restore
#line 195 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Index.cshtml"
                                         Write(Model.summary.tax.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>
                </div>
                <div class=""col-md-4"">
                    <h1 class=""text-right""><i class=""fas fa-file-invoice-dollar""></i></h1>
                </div>
            </div>
            <div class=""card-footer"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6969e8e1cbdb00e9adb4d4184023d6ae0aa9830e28395", async() => {
                WriteLiteral("Check Salary <i class=\"fas fa-arrow-circle-right\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n");
            WriteLiteral(@"        <div class=""card text-white bg-warning"">
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col"">

                    </div>
                    <div class=""col"">
                        <h1 class=""text-right""><i class=""fas fa-calendar-day fa-fw""></i></h1>
                    </div>
                </div>
            </div>
            <div class=""card-footer"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6969e8e1cbdb00e9adb4d4184023d6ae0aa9830e30226", async() => {
                WriteLiteral("Check Holiday <i class=\"fas fa-arrow-circle-right\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n");
#nullable restore
#line 225 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n\r\n");
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
