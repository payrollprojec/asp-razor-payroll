#pragma checksum "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\Attendance.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fae6f1642fd8dd791d74b1a86ef6ea17c3cd1a57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PayrollAppRazorPages.Pages.Staff.Pages_Staff_Attendance), @"mvc.1.0.razor-page", @"/Pages/Staff/Attendance.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fae6f1642fd8dd791d74b1a86ef6ea17c3cd1a57", @"/Pages/Staff/Attendance.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"861da5bb15acd1d78ca3a5927656d550f7c86cd6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Staff_Attendance : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control-sm mr-sm-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\Attendance.cshtml"
  
    ViewData["Title"] = "Attendance";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .fixedPart {
        position: -webkit-sticky;
        position: sticky;
        top: 0;
    }

    .fixedTable th {
        max-width: 60px;
        text-align: center;
    }

    .fixedTable td {
        text-align: center;
        background-color: white;
    }
</style>

<div class=""row"">
    <div class=""col""><h2>Attendance</h2></div><br />
    <div class=""col"">

        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fae6f1642fd8dd791d74b1a86ef6ea17c3cd1a574970", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fae6f1642fd8dd791d74b1a86ef6ea17c3cd1a575240", async() => {
                    WriteLiteral("\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 29 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\Attendance.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SelectedMonth);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 29 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\Attendance.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.Months;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fae6f1642fd8dd791d74b1a86ef6ea17c3cd1a577372", async() => {
                    WriteLiteral("\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 31 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\Attendance.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SelectedYear);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 31 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\Attendance.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.Years;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <input type=\"submit\" value=\"Filter\" />\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<br />\r\n\r\n\r\n");
#nullable restore
#line 40 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\Attendance.cshtml"
 if (Model.UserAttendance.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>No attendance found.</p>\r\n");
#nullable restore
#line 43 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\Attendance.cshtml"
}
else
{
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
            WriteLiteral("<div class=\"row\">\r\n");
            WriteLiteral(@"    <div class=""col"">
        <table class=""table table-bordered table-hover table-sm text-center"">
            <thead class=""thead-light"">
                <tr>
                    <th>
                        Day
                    </th>
                    <th>
                        Date
                    </th>
                    <th>
                        Status
                    </th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 75 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\Attendance.cshtml"
                 foreach (var item in Model.UserAttendance)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 79 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\Attendance.cshtml"
                    Write(item.PunchDate.Value.DayOfWeek);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 82 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\Attendance.cshtml"
                   Write(Html.DisplayFor(modelItem => item.PunchDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 85 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\Attendance.cshtml"
                         if (item.AttendanceStatus.Status != "Present")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span style=\"color: deeppink;\"> ");
#nullable restore
#line 87 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\Attendance.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.AttendanceStatus.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 88 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\Attendance.cshtml"
                        }
                        else
                        {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\Attendance.cshtml"
                   Write(Html.DisplayFor(modelItem => item.AttendanceStatus.Status));

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\Attendance.cshtml"
                                                                                   

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 96 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\Attendance.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n\r\n");
            WriteLiteral("    <div class=\"col-sm-7\" style=\"max-width:500px;\">\r\n        <div class=\" fixedPart\">\r\n");
            WriteLiteral(@"            <table class=""table table-sm table-bordered fixedTable"">
                <thead class=""thead-light"">
                    <tr>
                        <th scope=""col"">Attendance Status</th>
                        <th scope=""col"">Count</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <th scope=""row"">Present</th>
                        <td> ");
#nullable restore
#line 116 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\Attendance.cshtml"
                        Write(dict["Present"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th scope=\"row\">Absent</th>\r\n                        <td>");
#nullable restore
#line 120 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\Attendance.cshtml"
                       Write(dict["Absent"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th scope=\"row\">Leave</th>\r\n                        <td>");
#nullable restore
#line 124 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\Attendance.cshtml"
                       Write(dict["Leave"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th scope=\"row\">Sick</th>\r\n                        <td>");
#nullable restore
#line 128 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\Attendance.cshtml"
                       Write(dict["Sick"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                </tbody>\r\n            </table>\r\n            <br />\r\n");
            WriteLiteral("            <table class=\"table table-sm table-bordered fixedTable\">\r\n                <thead class=\"thead-light\">\r\n                    <tr>\r\n                        <th> ");
#nullable restore
#line 137 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\Attendance.cshtml"
                        Write(Html.DisplayNameFor(model => model.SelectedMonHoliday[0].HolidayDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                        <th> ");
#nullable restore
#line 138 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\Attendance.cshtml"
                        Write(Html.DisplayNameFor(model => model.SelectedMonHoliday[0].HolidayDes));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 142 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\Attendance.cshtml"
                     foreach (var item in Model.SelectedMonHoliday)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 146 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\Attendance.cshtml"
                       Write(Html.DisplayFor(modelItem => item.HolidayDate.Value.DayOfWeek));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>, </span>\r\n                            ");
#nullable restore
#line 147 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\Attendance.cshtml"
                       Write(Html.DisplayFor(modelItem => item.HolidayDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 150 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\Attendance.cshtml"
                       Write(Html.DisplayFor(modelItem => item.HolidayDes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 153 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\Attendance.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n\r\n\r\n    </div>\r\n");
            WriteLiteral("\r\n</div>\r\n");
#nullable restore
#line 163 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\Attendance.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PayrollAppRazorPages.Pages.Staff.AttendanceModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PayrollAppRazorPages.Pages.Staff.AttendanceModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PayrollAppRazorPages.Pages.Staff.AttendanceModel>)PageContext?.ViewData;
        public PayrollAppRazorPages.Pages.Staff.AttendanceModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
