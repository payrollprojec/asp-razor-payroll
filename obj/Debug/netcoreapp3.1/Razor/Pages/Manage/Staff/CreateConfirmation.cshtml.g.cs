#pragma checksum "C:\Users\Acer\source\repos\asp-razor-payroll-master\Pages\Manage\Staff\CreateConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9f58fb4dd873e052b83e8760562330cfa135463"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PayrollAppRazorPages.Pages.Manage.Staff.Pages_Manage_Staff_CreateConfirmation), @"mvc.1.0.razor-page", @"/Pages/Manage/Staff/CreateConfirmation.cshtml")]
namespace PayrollAppRazorPages.Pages.Manage.Staff
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
#line 1 "C:\Users\Acer\source\repos\asp-razor-payroll-master\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Acer\source\repos\asp-razor-payroll-master\Pages\_ViewImports.cshtml"
using PayrollAppRazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Acer\source\repos\asp-razor-payroll-master\Pages\_ViewImports.cshtml"
using PayrollAppRazorPages.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9f58fb4dd873e052b83e8760562330cfa135463", @"/Pages/Manage/Staff/CreateConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"189f02d3be71f439f042b75bdda0354ad9240599", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Manage_Staff_CreateConfirmation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Acer\source\repos\asp-razor-payroll-master\Pages\Manage\Staff\CreateConfirmation.cshtml"
  
    ViewData["Title"] = "CreateConfirmation";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Staff account created</h1>\n<p>Login Details</p>\n<hr />\n<p>Username: ");
#nullable restore
#line 10 "C:\Users\Acer\source\repos\asp-razor-payroll-master\Pages\Manage\Staff\CreateConfirmation.cshtml"
        Write(Model.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>Password: ");
#nullable restore
#line 11 "C:\Users\Acer\source\repos\asp-razor-payroll-master\Pages\Manage\Staff\CreateConfirmation.cshtml"
        Write(Model.Password);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n<br />\n<br />\n<div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9f58fb4dd873e052b83e8760562330cfa1354634564", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PayrollAppRazorPages.Pages.Manage.Staff.CreateConfirmationModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PayrollAppRazorPages.Pages.Manage.Staff.CreateConfirmationModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PayrollAppRazorPages.Pages.Manage.Staff.CreateConfirmationModel>)PageContext?.ViewData;
        public PayrollAppRazorPages.Pages.Manage.Staff.CreateConfirmationModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
