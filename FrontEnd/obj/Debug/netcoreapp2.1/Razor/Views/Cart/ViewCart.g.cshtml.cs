#pragma checksum "D:\Study\GuoHanwen\Master\Info6250\Assignment4\Assignment4\Views\Cart\ViewCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c58c197199e77d3764750a0d54a1c0269c62182"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_ViewCart), @"mvc.1.0.view", @"/Views/Cart/ViewCart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cart/ViewCart.cshtml", typeof(AspNetCore.Views_Cart_ViewCart))]
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
#line 5 "D:\Study\GuoHanwen\Master\Info6250\Assignment4\Assignment4\Views\Cart\ViewCart.cshtml"
using System.Collections;

#line default
#line hidden
#line 6 "D:\Study\GuoHanwen\Master\Info6250\Assignment4\Assignment4\Views\Cart\ViewCart.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c58c197199e77d3764750a0d54a1c0269c62182", @"/Views/Cart/ViewCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3fe9fc4680b8984f853a3014a8ac4f2e06c8ed2", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_ViewCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\Study\GuoHanwen\Master\Info6250\Assignment4\Assignment4\Views\Cart\ViewCart.cshtml"
  
    ViewData["Title"] = "ViewCart";

#line default
#line hidden
            BeginContext(99, 460, true);
            WriteLiteral(@"
<link href=""https://fonts.googleapis.com/css?family=Playfair+Display:700,900"" rel=""stylesheet"">
<link href=""https://getbootstrap.com/docs/4.1/examples/blog/blog.css"" rel=""stylesheet"">
<script src=""https://code.jquery.com/jquery-3.3.1.js""
        integrity=""sha256-2Kok7MbOyxpgUVvAk/HJ2jigOSYS2auK4Pfzbm7uH60=""
        crossorigin=""anonymous""></script>

<div class=""row"">
    <div class=""col-lg-2""></div>
    <h1 class=""col-lg-10"">Carts</h1>
</div>
");
            EndContext();
#line 18 "D:\Study\GuoHanwen\Master\Info6250\Assignment4\Assignment4\Views\Cart\ViewCart.cshtml"
  
    var totalPrice = 0.0;

#line default
#line hidden
            BeginContext(593, 10, true);
            WriteLiteral("<br><br>\r\n");
            EndContext();
#line 22 "D:\Study\GuoHanwen\Master\Info6250\Assignment4\Assignment4\Views\Cart\ViewCart.cshtml"
 foreach (var item in ViewBag.Items)
{
    var sumPrice = item.Price * item.Num;
    totalPrice += sumPrice;

#line default
#line hidden
            BeginContext(716, 276, true);
            WriteLiteral(@"    <div class=""row"">
        <div class=""col-md-2""></div>
        <div class=""col-md-8"">
            <div class=""card flex-md-row mb-4 shadow-sm h-md-250"">
                <div class=""card-body d-flex flex-column align-items-start"">
                    <h3 class=""mb-0"">");
            EndContext();
            BeginContext(993, 10, false);
#line 31 "D:\Study\GuoHanwen\Master\Info6250\Assignment4\Assignment4\Views\Cart\ViewCart.cshtml"
                                Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1003, 68, true);
            WriteLiteral("</h3>\r\n                    <strong class=\"d-inline-block mb-2\">Num: ");
            EndContext();
            BeginContext(1072, 8, false);
#line 32 "D:\Study\GuoHanwen\Master\Info6250\Assignment4\Assignment4\Views\Cart\ViewCart.cshtml"
                                                        Write(item.Num);

#line default
#line hidden
            EndContext();
            BeginContext(1080, 88, true);
            WriteLiteral("</strong>\r\n                    <strong class=\"d-inline-block mb-2 text-primary\">Price: $");
            EndContext();
            BeginContext(1169, 8, false);
#line 33 "D:\Study\GuoHanwen\Master\Info6250\Assignment4\Assignment4\Views\Cart\ViewCart.cshtml"
                                                                        Write(sumPrice);

#line default
#line hidden
            EndContext();
            BeginContext(1177, 128, true);
            WriteLiteral("</strong>\r\n                    <br>\r\n                    <div class=\"mb-0 row\">\r\n                        <input class=\"col-md-3\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1305, "\"", 1324, 2);
            WriteAttributeValue("", 1310, "count_", 1310, 6, true);
#line 36 "D:\Study\GuoHanwen\Master\Info6250\Assignment4\Assignment4\Views\Cart\ViewCart.cshtml"
WriteAttributeValue("", 1316, item.Id, 1316, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 1325, "\"", 1342, 1);
#line 36 "D:\Study\GuoHanwen\Master\Info6250\Assignment4\Assignment4\Views\Cart\ViewCart.cshtml"
WriteAttributeValue("", 1333, item.Num, 1333, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1343, 76, true);
            WriteLiteral(" required>\r\n                        <button class=\"btn btn-success col-md-3\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1419, "\"", 1439, 2);
            WriteAttributeValue("", 1424, "update_", 1424, 7, true);
#line 37 "D:\Study\GuoHanwen\Master\Info6250\Assignment4\Assignment4\Views\Cart\ViewCart.cshtml"
WriteAttributeValue("", 1431, item.Id, 1431, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 1440, "\"", 1456, 1);
#line 37 "D:\Study\GuoHanwen\Master\Info6250\Assignment4\Assignment4\Views\Cart\ViewCart.cshtml"
WriteAttributeValue("", 1448, item.Id, 1448, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1457, 140, true);
            WriteLiteral(">Update cart</button>\r\n                        <div class=\"col-md-3\"></div>\r\n                        <button class=\"btn btn-danger col-md-3\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1597, "\"", 1617, 2);
            WriteAttributeValue("", 1602, "remove_", 1602, 7, true);
#line 39 "D:\Study\GuoHanwen\Master\Info6250\Assignment4\Assignment4\Views\Cart\ViewCart.cshtml"
WriteAttributeValue("", 1609, item.Id, 1609, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1618, 141, true);
            WriteLiteral(">Remove</button>\r\n                    </div>\r\n                </div>\r\n                <img class=\"card-img-right flex-auto d-none d-lg-block\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1759, "\"", 1774, 1);
#line 42 "D:\Study\GuoHanwen\Master\Info6250\Assignment4\Assignment4\Views\Cart\ViewCart.cshtml"
WriteAttributeValue("", 1765, item.Img, 1765, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1775, 132, true);
            WriteLiteral(" width=\"200\" height=\"300\">\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <script type=\"text/javascript\">\r\n        $(\"#update_");
            EndContext();
            BeginContext(1908, 7, false);
#line 47 "D:\Study\GuoHanwen\Master\Info6250\Assignment4\Assignment4\Views\Cart\ViewCart.cshtml"
              Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1915, 58, true);
            WriteLiteral("\").click(function () {\r\n            var count = $(\"#count_");
            EndContext();
            BeginContext(1974, 7, false);
#line 48 "D:\Study\GuoHanwen\Master\Info6250\Assignment4\Assignment4\Views\Cart\ViewCart.cshtml"
                             Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1981, 354, true);
            WriteLiteral(@""").val();
            if (count == null||count=="""") {
                alert(""Please input the number first."");
                return;
            }
            if (!checkNum(count)) {
                alert(""Please input a valid number."");
                return;
            }
            count = parseInt(count);
            var item = {""Id"":");
            EndContext();
            BeginContext(2336, 7, false);
#line 58 "D:\Study\GuoHanwen\Master\Info6250\Assignment4\Assignment4\Views\Cart\ViewCart.cshtml"
                        Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2343, 10, true);
            WriteLiteral(",\"Title\":\"");
            EndContext();
            BeginContext(2354, 10, false);
#line 58 "D:\Study\GuoHanwen\Master\Info6250\Assignment4\Assignment4\Views\Cart\ViewCart.cshtml"
                                          Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2364, 22, true);
            WriteLiteral("\",\"Num\":count,\"Price\":");
            EndContext();
            BeginContext(2387, 10, false);
#line 58 "D:\Study\GuoHanwen\Master\Info6250\Assignment4\Assignment4\Views\Cart\ViewCart.cshtml"
                                                                           Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(2397, 8, true);
            WriteLiteral(",\"Img\":\"");
            EndContext();
            BeginContext(2406, 8, false);
#line 58 "D:\Study\GuoHanwen\Master\Info6250\Assignment4\Assignment4\Views\Cart\ViewCart.cshtml"
                                                                                              Write(item.Img);

#line default
#line hidden
            EndContext();
            BeginContext(2414, 514, true);
            WriteLiteral(@"""};
            console.log(count);
            console.log(item);
            var json = JSON.stringify(item);
            console.log(json);
            $.ajax({
                type: 'PUT',
                url: '/Cart/UpdateCart',
                data: json,
                dataType: ""json"",
                contentType: ""application/json"",
                success: function (data) {
                    location.reload(true);
                }
            });
        });

        $(""#remove_");
            EndContext();
            BeginContext(2929, 7, false);
#line 75 "D:\Study\GuoHanwen\Master\Info6250\Assignment4\Assignment4\Views\Cart\ViewCart.cshtml"
              Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2936, 118, true);
            WriteLiteral("\").click(function () {\r\n            $.ajax({\r\n                type: \'Delete\',\r\n                url: \'/Cart/DeleteCart/");
            EndContext();
            BeginContext(3055, 7, false);
#line 78 "D:\Study\GuoHanwen\Master\Info6250\Assignment4\Assignment4\Views\Cart\ViewCart.cshtml"
                                  Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(3062, 424, true);
            WriteLiteral(@"',
                success: function (data) {
                    location.reload(true);
                }
            });
        });

        function checkNum(input) {
            var reg = /^[0-9]+.?[0-9]*$/;
            var num = input;
            if (!reg.test(num)) {
                return false;
            }
            else {
                return true;
            }
        }
    </script>
");
            EndContext();
#line 96 "D:\Study\GuoHanwen\Master\Info6250\Assignment4\Assignment4\Views\Cart\ViewCart.cshtml"
}

#line default
#line hidden
            BeginContext(3489, 97, true);
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-lg-2\"></div>\r\n    <div class=\"col-lg-2\"><h2>Total Price: $");
            EndContext();
            BeginContext(3587, 10, false);
#line 99 "D:\Study\GuoHanwen\Master\Info6250\Assignment4\Assignment4\Views\Cart\ViewCart.cshtml"
                                       Write(totalPrice);

#line default
#line hidden
            EndContext();
            BeginContext(3597, 359, true);
            WriteLiteral(@"</h2></div>
    <div class=""col-lg-4""></div>
    <button class=""btn btn-primary col-lg-2"" id=""placeOrder"">Checkout</button>
    <div class=""col-lg-2""></div>
</div>
<script type=""text/javascript"">
    $(""#placeOrder"").click(function () {
        $.ajax({
            type: 'POST',
            url: '/Order/AddOrder',
            data: JSON.stringify(");
            EndContext();
            BeginContext(3957, 17, false);
#line 109 "D:\Study\GuoHanwen\Master\Info6250\Assignment4\Assignment4\Views\Cart\ViewCart.cshtml"
                            Write(ViewBag.ItemsJson);

#line default
#line hidden
            EndContext();
            BeginContext(3974, 374, true);
            WriteLiteral(@"),
            dataType: ""json"",
            contentType: ""application/json"",
            success: function (data, res) {
                    if (data == true) {
                        alert(""Order Placed!"");
                        window.location.href =""/Order/GetMostRecentOrder"";
                    }
                }
        })
    });
</script>




");
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
