#pragma checksum "D:\Study\GuoHanwen\Master\Info6250\Assignment4\Assignment4\Views\User\UserInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b10643c820ab5091a367ba8daec49c9accb7efa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_UserInfo), @"mvc.1.0.view", @"/Views/User/UserInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/UserInfo.cshtml", typeof(AspNetCore.Views_User_UserInfo))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\Study\GuoHanwen\Master\Info6250\Assignment4\Assignment4\Views\_ViewImports.cshtml"
using Assignment4;

#line default
#line hidden
#line 2 "D:\Study\GuoHanwen\Master\Info6250\Assignment4\Assignment4\Views\_ViewImports.cshtml"
using Assignment4.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b10643c820ab5091a367ba8daec49c9accb7efa", @"/Views/User/UserInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3fe9fc4680b8984f853a3014a8ac4f2e06c8ed2", @"/Views/_ViewImports.cshtml")]
    public class Views_User_UserInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("needs-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/User/UpdateAccount"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\Study\GuoHanwen\Master\Info6250\Assignment4\Assignment4\Views\User\UserInfo.cshtml"
  
    ViewData["Title"] = "UserInfo";

#line default
#line hidden
            BeginContext(46, 305, true);
            WriteLiteral(@"
<!-- Custom styles for this template -->
<link href=""https://getbootstrap.com/docs/4.1/examples/checkout/form-validation.css"" rel=""stylesheet"">



<div class=""container"">
    <div class=""row"">
        <div class=""col-md-8 order-md-1"">
            <h4 class=""mb-3"">Account Info</h4>
            ");
            EndContext();
            BeginContext(351, 1579, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62c24912bb6d45f4b10128a28c599626", async() => {
                BeginContext(436, 261, true);
                WriteLiteral(@"
                <div class=""mb-3"">
                    <label for=""username"">Username</label>
                    <div class=""input-group"">
                        <input type=""text"" class=""form-control"" id=""username"" name=""username"" placeholder=""Username""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 697, "\"", 722, 1);
#line 19 "D:\Study\GuoHanwen\Master\Info6250\Assignment4\Assignment4\Views\User\UserInfo.cshtml"
WriteAttributeValue("", 705, ViewBag.Username, 705, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(723, 435, true);
                WriteLiteral(@" required>
                        <div class=""invalid-feedback"" style=""width: 100%;"">
                            Your username is required.
                        </div>
                    </div>
                </div>

                <div class=""mb-3"">
                    <label for=""email"">Email</label>
                    <input type=""email"" class=""form-control"" id=""email"" name=""email"" placeholder=""you@example.com""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1158, "\"", 1180, 1);
#line 28 "D:\Study\GuoHanwen\Master\Info6250\Assignment4\Assignment4\Views\User\UserInfo.cshtml"
WriteAttributeValue("", 1166, ViewBag.Email, 1166, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1181, 742, true);
                WriteLiteral(@" readonly>
                    <div class=""invalid-feedback"">
                        Please enter a valid email address for.
                    </div>
                </div>

                <div class=""mb-3"">
                    <label for=""password"">Password</label>
                    <input type=""text"" class=""form-control"" id=""password"" name=""password"" placeholder=""Please enter your new password."" required>
                    <div class=""invalid-feedback"">
                        Please enter your new password.
                    </div>
                </div>
                <hr class=""mb-4"">
                <button class=""btn btn-danger btn-lg btn-block"" type=""submit"">Update Your Account</button>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1930, 32, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591