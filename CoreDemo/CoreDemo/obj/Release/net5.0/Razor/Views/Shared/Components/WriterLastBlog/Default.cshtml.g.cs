#pragma checksum "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterLastBlog\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5e610a5a0fbef28a615181679752aaf66158db9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_WriterLastBlog_Default), @"mvc.1.0.view", @"/Views/Shared/Components/WriterLastBlog/Default.cshtml")]
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
#line 1 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5e610a5a0fbef28a615181679752aaf66158db9", @"/Views/Shared/Components/WriterLastBlog/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_WriterLastBlog_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"tech-btm\">\r\n    <h4>Yazarın Diğer Yazıları</h4>\r\n");
#nullable restore
#line 6 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterLastBlog\Default.cshtml"
     foreach (var item in Model.OrderByDescending(x=>x.ID).Take(3))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"blog-grids row mb-3\">\r\n            <div class=\"col-md-5 blog-grid-left\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 300, "\"", 333, 2);
            WriteAttributeValue("", 307, "/Blog/BlogReadAll/", 307, 18, true);
#nullable restore
#line 10 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterLastBlog\Default.cshtml"
WriteAttributeValue("", 325, item.ID, 325, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 361, "\"", 378, 1);
#nullable restore
#line 11 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterLastBlog\Default.cshtml"
WriteAttributeValue("", 367, item.Image, 367, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 397, "\"", 403, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </a>\r\n            </div>\r\n            <div class=\"col-md-7 blog-grid-right\">\r\n\r\n                <h5>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 547, "\"", 580, 2);
            WriteAttributeValue("", 554, "/Blog/BlogReadAll/", 554, 18, true);
#nullable restore
#line 17 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterLastBlog\Default.cshtml"
WriteAttributeValue("", 572, item.ID, 572, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 17 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterLastBlog\Default.cshtml"
                                                    Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </h5>\r\n                <div class=\"sub-meta\">\r\n                    <span>\r\n                        <i class=\"far fa-clock\"></i> ");
#nullable restore
#line 21 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterLastBlog\Default.cshtml"
                                                 Write(((DateTime)item.CreateDate).ToString("dd MMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </span>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n");
#nullable restore
#line 27 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\WriterLastBlog\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591