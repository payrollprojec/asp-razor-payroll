#pragma checksum "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Manage\Staff\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c37e2452b8e31f35afba3708b557588b667e70c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PayrollAppRazorPages.Pages.Manage.Staff.Pages_Manage_Staff_Delete), @"mvc.1.0.razor-page", @"/Pages/Manage/Staff/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{Id}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c37e2452b8e31f35afba3708b557588b667e70c1", @"/Pages/Manage/Staff/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"861da5bb15acd1d78ca3a5927656d550f7c86cd6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Manage_Staff_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Manage\Staff\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card\" style=\"max-width:900px;\">\r\n    <h4 class=\"card-header\">Are you sure you want to delete user - ");
#nullable restore
#line 8 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Manage\Staff\Delete.cshtml"
                                                              Write(Html.DisplayFor(model => model.applicationUser.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <div class=\"card-body\">\r\n        <dl class=\"row\">\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 12 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Manage\Staff\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.applicationUser.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 15 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Manage\Staff\Delete.cshtml"
           Write(Html.DisplayFor(model => model.applicationUser.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 18 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Manage\Staff\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.applicationUser.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 21 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Manage\Staff\Delete.cshtml"
           Write(Html.DisplayFor(model => model.applicationUser.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 24 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Manage\Staff\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.applicationUser.ICNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 27 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Manage\Staff\Delete.cshtml"
           Write(Html.DisplayFor(model => model.applicationUser.ICNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 30 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Manage\Staff\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.applicationUser.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 33 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Manage\Staff\Delete.cshtml"
           Write(Html.DisplayFor(model => model.applicationUser.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 37 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Manage\Staff\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.applicationUser.StaffData.DOB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 40 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Manage\Staff\Delete.cshtml"
           Write(Html.DisplayFor(model => model.applicationUser.StaffData.DOB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 43 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Manage\Staff\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.applicationUser.StaffData.DateJoined));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 46 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Manage\Staff\Delete.cshtml"
           Write(Html.DisplayFor(model => model.applicationUser.StaffData.DateJoined));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 49 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Manage\Staff\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.applicationUser.StaffData.TaxNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 52 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Manage\Staff\Delete.cshtml"
           Write(Html.DisplayFor(model => model.applicationUser.StaffData.TaxNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 55 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Manage\Staff\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.applicationUser.StaffData.EPFNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 58 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Manage\Staff\Delete.cshtml"
           Write(Html.DisplayFor(model => model.applicationUser.StaffData.EPFNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 61 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Manage\Staff\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.applicationUser.StaffData.SocsoNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 64 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Manage\Staff\Delete.cshtml"
           Write(Html.DisplayFor(model => model.applicationUser.StaffData.SocsoNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n        <hr />\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c37e2452b8e31f35afba3708b557588b667e70c112466", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c37e2452b8e31f35afba3708b557588b667e70c112737", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 69 "C:\Users\Wen\source\repos\PayrollAppRazorPages5-final4\Pages\Manage\Staff\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.applicationUser.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" />\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c37e2452b8e31f35afba3708b557588b667e70c114554", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PayrollAppRazorPages.Pages.Manage.Staff.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PayrollAppRazorPages.Pages.Manage.Staff.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PayrollAppRazorPages.Pages.Manage.Staff.DeleteModel>)PageContext?.ViewData;
        public PayrollAppRazorPages.Pages.Manage.Staff.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
