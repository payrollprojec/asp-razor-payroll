#pragma checksum "C:\Users\Wen\source\repos\PayrollAppRazorPages\Pages\Manage\Staff\CreateConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bc720362879c47604cee72848f3112384aaf590"
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
#line 1 "C:\Users\Wen\source\repos\PayrollAppRazorPages\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Wen\source\repos\PayrollAppRazorPages\Pages\_ViewImports.cshtml"
using PayrollAppRazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Wen\source\repos\PayrollAppRazorPages\Pages\_ViewImports.cshtml"
using PayrollAppRazorPages.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bc720362879c47604cee72848f3112384aaf590", @"/Pages/Manage/Staff/CreateConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"861da5bb15acd1d78ca3a5927656d550f7c86cd6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Manage_Staff_CreateConfirmation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Wen\source\repos\PayrollAppRazorPages\Pages\Manage\Staff\CreateConfirmation.cshtml"
  
    ViewData["Title"] = "CreateConfirmation";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Staff account created</h1>\r\n<p>Login Details</p>\r\n<hr />\r\n<p>Username: ");
#nullable restore
#line 10 "C:\Users\Wen\source\repos\PayrollAppRazorPages\Pages\Manage\Staff\CreateConfirmation.cshtml"
        Write(Model.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Password: ");
#nullable restore
#line 11 "C:\Users\Wen\source\repos\PayrollAppRazorPages\Pages\Manage\Staff\CreateConfirmation.cshtml"
        Write(Model.Password);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
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
