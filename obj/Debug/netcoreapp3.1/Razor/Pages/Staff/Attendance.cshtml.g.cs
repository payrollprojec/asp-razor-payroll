#pragma checksum "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\Attendance.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc88fcf438a74041acce2c27d23b205914816a17"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc88fcf438a74041acce2c27d23b205914816a17", @"/Pages/Staff/Attendance.cshtml")]
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

<div class=""container row jumbotron bg-info"" style=""margin-left: 10px;"">
    <div class=""container row"">
        <div class=""col-auto text-white""><h4>Attendance</h4></div>
        <div class=""col-auto"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc88fcf438a74041acce2c27d23b205914816a175087", async() => {
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc88fcf438a74041acce2c27d23b205914816a175361", async() => {
                    WriteLiteral("\r\n                ");
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
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc88fcf438a74041acce2c27d23b205914816a177501", async() => {
                    WriteLiteral("\r\n                ");
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
                WriteLiteral("\r\n                <input type=\"submit\" value=\"Filter\" />\r\n            ");
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
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
#nullable restore
#line 39 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\Attendance.cshtml"
 if (Model.UserAttendance.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>No attendance found in ");
#nullable restore
#line 41 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\Attendance.cshtml"
                         Write(Model.SelectedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 42 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\Attendance.cshtml"
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
            WriteLiteral("    <div class=\"row\" style=\"padding: 0 55px; margin-top: -66px;\">\r\n");
            WriteLiteral("        <div class=\"col\"></div>\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("        <div class=\"col-sm-7\" style=\"max-width:500px;\">\r\n            <div class=\" fixedPart\">\r\n");
            WriteLiteral(@"                <table class=""table table-sm table-bordered table-hover fixedTable"">
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
            WriteLiteral("/");
#nullable restore
#line 116 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\Attendance.cshtml"
                                             Write(Model.WeekdaysCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <th scope=\"row\">Absent</th>\r\n                            <td>");
#nullable restore
#line 120 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\Attendance.cshtml"
                           Write(dict["Absent"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <th scope=\"row\">Leave</th>\r\n                            <td>");
#nullable restore
#line 124 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\Attendance.cshtml"
                           Write(dict["Leave"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <th scope=\"row\">Sick</th>\r\n                            <td>");
#nullable restore
#line 128 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\Attendance.cshtml"
                           Write(dict["Sick"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n                    </tbody>\r\n                </table>\r\n                <br />\r\n");
            WriteLiteral("            </div>\r\n\r\n\r\n        </div>\r\n");
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 163 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\Attendance.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 165 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\Attendance.cshtml"
  
    int days = DateTime.DaysInMonth(int.Parse(Model.SelectedYear), int.Parse(Model.SelectedMonth));
    List<DateTime> dates = new List<DateTime>();
    for (int i = 1; i <= days; i++)
    {
        dates.Add(new DateTime(int.Parse(Model.SelectedYear), int.Parse(Model.SelectedMonth), i));
    }
    //int nWeeks = (int)Math.Ceiling((double)days / (double)7);
    List<List<DateTime>> datesPerWeek = new List<List<DateTime>>();
    int nWeeks = 1;
    foreach (DateTime dt in dates)
    {
        if (dt.DayOfWeek == DayOfWeek.Saturday)
        {
            nWeeks++;
        }
    }
    for (int i = 0; i < nWeeks; i++)
    {
        datesPerWeek.Add(new List<DateTime>());
    }
    int n = 0;
    foreach (DateTime dt in dates)
    {
        datesPerWeek[n].Add(dt);
        if (dt.DayOfWeek == DayOfWeek.Saturday)
        {
            n++;
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table table-bordered table-hover table-sm text-center"">
    <thead class=""thead-light"">
        <tr>
            <th>
                Sun
            </th>
            <th>
                Mon
            </th>
            <th>
                Tue
            </th>
            <th>
                Wed
            </th>
            <th>
                Thu
            </th>
            <th>
                Fri
            </th>
            <th>
                Sat
            </th>
        </tr>
    </thead>
");
#nullable restore
#line 223 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\Attendance.cshtml"
     foreach (List<DateTime> dts in datesPerWeek)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n");
#nullable restore
#line 226 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\Attendance.cshtml"
             foreach (DateTime dt in dts)
            {
                if (dt.Day == 1 && dt.DayOfWeek != DayOfWeek.Sunday)
                {
                    int firstday = (int)dt.DayOfWeek;
                    for (int j = 0; j < firstday; j++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td style=\"background-color: grey;\"></td>\r\n");
#nullable restore
#line 234 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\Attendance.cshtml"
                    }
                }


#line default
#line hidden
#nullable disable
            WriteLiteral("                <td");
            BeginWriteAttribute("style", " style=\"", 7776, "\"", 7899, 7);
#nullable restore
#line 237 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\Attendance.cshtml"
WriteAttributeValue("", 7784, Model.Days.Contains(((int)dt.DayOfWeek).ToString())? "background-color: salmon": "", 7784, 86, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7870, ";", 7870, 1, true);
            WriteAttributeValue(" ", 7871, "width:", 7872, 7, true);
            WriteAttributeValue(" ", 7878, "75px;", 7879, 6, true);
            WriteAttributeValue(" ", 7884, "height:", 7885, 8, true);
            WriteAttributeValue(" ", 7892, "80px;", 7893, 6, true);
            WriteAttributeValue(" ", 7898, "", 7899, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"row\">\r\n                        <div class=\"col\">\r\n                            ");
#nullable restore
#line 240 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\Attendance.cshtml"
                       Write(dt.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col\">\r\n");
#nullable restore
#line 243 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\Attendance.cshtml"
                             foreach (var att in Model.UserAttendance)
                            {
                                if (((DateTime)att.PunchDate).Date == dt.Date)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span");
            BeginWriteAttribute("class", " class=\"", 8356, "\"", 8433, 2);
            WriteAttributeValue("", 8364, "text-", 8364, 5, true);
#nullable restore
#line 247 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\Attendance.cshtml"
WriteAttributeValue("", 8369, att.AttendanceStatus.Status == "Present"? "success":"warning", 8369, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 247 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\Attendance.cshtml"
                                                                                                                   Write(att.AttendanceStatus.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br />\r\n");
#nullable restore
#line 248 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\Attendance.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n\r\n");
#nullable restore
#line 253 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\Attendance.cshtml"
                     foreach (var hol in Model.Holidays)
                    {
                        if (((DateTime)hol.HolidayDate).Date == dt.Date)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"small\" style=\"word-break: break-all; color: #666\">");
#nullable restore
#line 257 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\Attendance.cshtml"
                                                                                      Write(hol.HolidayDes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 258 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\Attendance.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
#nullable restore
#line 262 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\Attendance.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 264 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Staff\Attendance.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
