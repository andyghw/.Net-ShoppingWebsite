#pragma checksum "D:\Study\GuoHanwen\Master\Info6250\Assignment4\Assignment4\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68723388f3003fd4e8357e3a4ce3594e20f424eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.razor-page", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68723388f3003fd4e8357e3a4ce3594e20f424eb", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3fe9fc4680b8984f853a3014a8ac4f2e06c8ed2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(7, 3003, true);
            WriteLiteral(@"
<div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"">
    <ol class=""carousel-indicators"">
        <li data-target=""#myCarousel"" data-slide-to=""0"" class=""active""></li>
        <li data-target=""#myCarousel"" data-slide-to=""1""></li>
        <li data-target=""#myCarousel"" data-slide-to=""2""></li>
    </ol>
    <div class=""carousel-inner"">
        <div class=""carousel-item active"">
            <img src=""https://i5.walmartimages.com/dfw/4ff9c6c9-d93a/k2-_a523287f-fdc0-48aa-8af2-6cb67b984699.v1.jpg?odnWidth=1360&odnHeight=600&odnBg=ffffff"" />
            <div class=""container"">
                <div class=""carousel-caption text-left text-body"">
                    <h1>Wicked good finds</h1>
                    <p>Scare up costumes, candy & all your <br>hair-raising mus-haves.</p>
                    <p><a class=""btn btn-lg btn-primary"" href=""#"" role=""button"">Read more</a></p>
                </div>
            </div>
        </div>
        <div class=""carousel-item"">
            <img src");
            WriteLiteral(@"=""https://i5.walmartimages.com/dfw/4ff9c6c9-45d6/k2-_eca930be-3aca-4a47-b5c7-0e2fc25a9f1e.v1.jpg?odnWidth=1360&odnHeight=600&odnBg=ffffff"" />
            <div class=""container"">
                <div class=""carousel-caption text-left"">
                    <h1>Turn over a new look</h1>
                    <p>Creating an inviting space with warm decor & cozy accents.</p>
                    <p><a class=""btn btn-lg btn-primary"" role=""button"">Read more</a></p>
                </div>
            </div>
        </div>
        <div class=""carousel-item"">
            <img src=""https://ec-us-i5.wal.co/dfw/4ff9c6c9-c278/k2-_c964ac44-da7b-42e6-b154-9878e9e313e4.v1.jpg-3f46cc854fc0b9dbba0d2d84394cec139340d8f1-optim-1360x600.jpg?odnBg=ffffff"" />
            <div class=""container"">
                <div class=""carousel-caption text-left"">
                    <h1>Women's It List</h1>
                    <p>Refresh your look with pladids, statement sleeves & more.</p>
                    <p><a class=""btn btn-lg ");
            WriteLiteral(@"btn-primary"" href=""#"" role=""button"">Read more</a></p>
                </div>
            </div>
        </div>
    </div>
    <a class=""carousel-control-prev"" href=""#myCarousel"" role=""button"" data-slide=""prev"">
        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Previous</span>
    </a>
    <a class=""carousel-control-next"" href=""#myCarousel"" role=""button"" data-slide=""next"">
        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Next</span>
    </a>
</div>


<!-- Marketing messaging and featurettes
================================================== -->
<!-- Wrap the rest of the page in another container to center all the content. -->

<div class=""container marketing"">
    <!-- START THE FEATURETTES -->
    <hr class=""featurette-divider"">
    <div class=""row featurette"">
        <div class=""col-md-7"">
            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3010, "\"", 3063, 2);
            WriteAttributeValue("", 3017, "/Product/ProductDetail/", 3017, 23, true);
#line 61 "D:\Study\GuoHanwen\Master\Info6250\Assignment4\Assignment4\Views\Home\Index.cshtml"
WriteAttributeValue("", 3040, ViewBag.Products[0].Id, 3040, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3064, 32, true);
            WriteLiteral("><h2 class=\"featurette-heading\">");
            EndContext();
            BeginContext(3097, 24, false);
#line 61 "D:\Study\GuoHanwen\Master\Info6250\Assignment4\Assignment4\Views\Home\Index.cshtml"
                                                                                               Write(ViewBag.Products[0].Name);

#line default
#line hidden
            EndContext();
            BeginContext(3121, 40, true);
            WriteLiteral("</h2></a>\r\n            <p class=\"lead\">$");
            EndContext();
            BeginContext(3162, 25, false);
#line 62 "D:\Study\GuoHanwen\Master\Info6250\Assignment4\Assignment4\Views\Home\Index.cshtml"
                        Write(ViewBag.Products[0].Price);

#line default
#line hidden
            EndContext();
            BeginContext(3187, 35, true);
            WriteLiteral("</p>\r\n            <p class=\"lead\">$");
            EndContext();
            BeginContext(3223, 24, false);
#line 63 "D:\Study\GuoHanwen\Master\Info6250\Assignment4\Assignment4\Views\Home\Index.cshtml"
                        Write(ViewBag.Products[0].Text);

#line default
#line hidden
            EndContext();
            BeginContext(3247, 68, true);
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"col-md-5\">\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3315, "\"", 3368, 2);
            WriteAttributeValue("", 3322, "/Product/ProductDetail/", 3322, 23, true);
#line 66 "D:\Study\GuoHanwen\Master\Info6250\Assignment4\Assignment4\Views\Home\Index.cshtml"
WriteAttributeValue("", 3345, ViewBag.Products[0].Id, 3345, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3369, 5, true);
            WriteLiteral("><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3374, "\"", 3408, 1);
#line 66 "D:\Study\GuoHanwen\Master\Info6250\Assignment4\Assignment4\Views\Home\Index.cshtml"
WriteAttributeValue("", 3380, ViewBag.Products[0].Imgs[0], 3380, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3409, 192, true);
            WriteLiteral(" width=\"300\" height=\"400\"></a>\r\n        </div>\r\n    </div>\r\n\r\n    <hr class=\"featurette-divider\">\r\n\r\n    <div class=\"row featurette\">\r\n        <div class=\"col-md-7 order-md-2\">\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3601, "\"", 3654, 2);
            WriteAttributeValue("", 3608, "/Product/ProductDetail/", 3608, 23, true);
#line 74 "D:\Study\GuoHanwen\Master\Info6250\Assignment4\Assignment4\Views\Home\Index.cshtml"
WriteAttributeValue("", 3631, ViewBag.Products[1].Id, 3631, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3655, 32, true);
            WriteLiteral("><h2 class=\"featurette-heading\">");
            EndContext();
            BeginContext(3688, 24, false);
#line 74 "D:\Study\GuoHanwen\Master\Info6250\Assignment4\Assignment4\Views\Home\Index.cshtml"
                                                                                               Write(ViewBag.Products[1].Name);

#line default
#line hidden
            EndContext();
            BeginContext(3712, 40, true);
            WriteLiteral("</h2></a>\r\n            <p class=\"lead\">$");
            EndContext();
            BeginContext(3753, 25, false);
#line 75 "D:\Study\GuoHanwen\Master\Info6250\Assignment4\Assignment4\Views\Home\Index.cshtml"
                        Write(ViewBag.Products[1].Price);

#line default
#line hidden
            EndContext();
            BeginContext(3778, 35, true);
            WriteLiteral("</p>\r\n            <p class=\"lead\">$");
            EndContext();
            BeginContext(3814, 24, false);
#line 76 "D:\Study\GuoHanwen\Master\Info6250\Assignment4\Assignment4\Views\Home\Index.cshtml"
                        Write(ViewBag.Products[1].Text);

#line default
#line hidden
            EndContext();
            BeginContext(3838, 79, true);
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"col-md-5 order-md-1\">\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3917, "\"", 3970, 2);
            WriteAttributeValue("", 3924, "/Product/ProductDetail/", 3924, 23, true);
#line 79 "D:\Study\GuoHanwen\Master\Info6250\Assignment4\Assignment4\Views\Home\Index.cshtml"
WriteAttributeValue("", 3947, ViewBag.Products[1].Id, 3947, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3971, 5, true);
            WriteLiteral("><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3976, "\"", 4010, 1);
#line 79 "D:\Study\GuoHanwen\Master\Info6250\Assignment4\Assignment4\Views\Home\Index.cshtml"
WriteAttributeValue("", 3982, ViewBag.Products[1].Imgs[0], 3982, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4011, 181, true);
            WriteLiteral(" width=\"300\" height=\"400\"></a>\r\n        </div>\r\n    </div>\r\n\r\n    <hr class=\"featurette-divider\">\r\n\r\n    <div class=\"row featurette\">\r\n        <div class=\"col-md-7\">\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4192, "\"", 4245, 2);
            WriteAttributeValue("", 4199, "/Product/ProductDetail/", 4199, 23, true);
#line 87 "D:\Study\GuoHanwen\Master\Info6250\Assignment4\Assignment4\Views\Home\Index.cshtml"
WriteAttributeValue("", 4222, ViewBag.Products[2].Id, 4222, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4246, 32, true);
            WriteLiteral("><h2 class=\"featurette-heading\">");
            EndContext();
            BeginContext(4279, 24, false);
#line 87 "D:\Study\GuoHanwen\Master\Info6250\Assignment4\Assignment4\Views\Home\Index.cshtml"
                                                                                               Write(ViewBag.Products[2].Name);

#line default
#line hidden
            EndContext();
            BeginContext(4303, 40, true);
            WriteLiteral("</h2></a>\r\n            <p class=\"lead\">$");
            EndContext();
            BeginContext(4344, 25, false);
#line 88 "D:\Study\GuoHanwen\Master\Info6250\Assignment4\Assignment4\Views\Home\Index.cshtml"
                        Write(ViewBag.Products[2].Price);

#line default
#line hidden
            EndContext();
            BeginContext(4369, 35, true);
            WriteLiteral("</p>\r\n            <p class=\"lead\">$");
            EndContext();
            BeginContext(4405, 24, false);
#line 89 "D:\Study\GuoHanwen\Master\Info6250\Assignment4\Assignment4\Views\Home\Index.cshtml"
                        Write(ViewBag.Products[2].Text);

#line default
#line hidden
            EndContext();
            BeginContext(4429, 68, true);
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"col-md-5\">\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4497, "\"", 4550, 2);
            WriteAttributeValue("", 4504, "/Product/ProductDetail/", 4504, 23, true);
#line 92 "D:\Study\GuoHanwen\Master\Info6250\Assignment4\Assignment4\Views\Home\Index.cshtml"
WriteAttributeValue("", 4527, ViewBag.Products[2].Id, 4527, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4551, 5, true);
            WriteLiteral("><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 4556, "\"", 4590, 1);
#line 92 "D:\Study\GuoHanwen\Master\Info6250\Assignment4\Assignment4\Views\Home\Index.cshtml"
WriteAttributeValue("", 4562, ViewBag.Products[2].Imgs[0], 4562, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4591, 95, true);
            WriteLiteral(" width=\"300\" height=\"400\"></a>\r\n</div>\r\n    </div>\r\n\r\n    <hr class=\"featurette-divider\">\r\n    ");
            EndContext();
            BeginContext(4687, 16, false);
#line 97 "D:\Study\GuoHanwen\Master\Info6250\Assignment4\Assignment4\Views\Home\Index.cshtml"
Write(ViewBag.Username);

#line default
#line hidden
            EndContext();
            BeginContext(4703, 145, true);
            WriteLiteral("\r\n    <!-- /END THE FEATURETTES -->\r\n\r\n</div><!-- /.container -->\r\n\r\n<script type=\"text/javascript\">\r\n    $(function () {\r\n        var username=\"");
            EndContext();
            BeginContext(4849, 16, false);
#line 104 "D:\Study\GuoHanwen\Master\Info6250\Assignment4\Assignment4\Views\Home\Index.cshtml"
                 Write(ViewBag.Username);

#line default
#line hidden
            EndContext();
            BeginContext(4865, 221, true);
            WriteLiteral("\";\r\n        if (username==\"\") {\r\n            $(\"#log\").show();\r\n            $(\"#menu\").hide();\r\n        }\r\n        else {\r\n            $(\"#log\").hide();\r\n            $(\"#menu\").show();\r\n        }\r\n    });\r\n</script>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Views_Home_Index> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Views_Home_Index> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Views_Home_Index>)PageContext?.ViewData;
        public Views_Home_Index Model => ViewData.Model;
    }
}
#pragma warning restore 1591
