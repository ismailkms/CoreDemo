#pragma checksum "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminMessage\MessageDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e16c8b6a288067de67b3251b90c8387fa8426064"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminMessage_MessageDetails), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminMessage/MessageDetails.cshtml")]
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
#nullable restore
#line 1 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\_ViewImports.cshtml"
using CoreDemo.Areas.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\_ViewImports.cshtml"
using CoreDemo.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e16c8b6a288067de67b3251b90c8387fa8426064", @"/Areas/Admin/Views/AdminMessage/MessageDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b881055197282d0a2ab51004156381e82f1e1fbc", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminMessage_MessageDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Message2>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminMessage\MessageDetails.cshtml"
  
    ViewData["Title"] = "MessageDetails";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Mesaj Detay Sayfası</h1>\r\n<br />\r\n");
#nullable restore
#line 11 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminMessage\MessageDetails.cshtml"
Write(Html.Label("Mesaj ID"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>");
#nullable restore
#line 12 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminMessage\MessageDetails.cshtml"
Write(Model.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<br />\r\n");
#nullable restore
#line 14 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminMessage\MessageDetails.cshtml"
Write(Html.Label("Mesaj Başlığı"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>");
#nullable restore
#line 15 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminMessage\MessageDetails.cshtml"
Write(Model.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<br />\r\n");
#nullable restore
#line 17 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminMessage\MessageDetails.cshtml"
Write(Html.Label("Mesaj İçeriği"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>");
#nullable restore
#line 18 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminMessage\MessageDetails.cshtml"
Write(Model.Details);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<br />\r\n<a href=\"/Admin/AdminMessage/InBox/\" class=\"btn btn-info\">Mesajlara Dön</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Message2> Html { get; private set; }
    }
}
#pragma warning restore 1591
