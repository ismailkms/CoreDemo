#pragma checksum "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogLast3Post\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83ee6481ec7e668c191656e31c8e546d0eba59d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BlogLast3Post_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BlogLast3Post/Default.cshtml")]
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
#nullable restore
#line 2 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogLast3Post\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83ee6481ec7e668c191656e31c8e546d0eba59d5", @"/Views/Shared/Components/BlogLast3Post/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_BlogLast3Post_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"tech-btm\">\r\n    <h3>Son Postlar</h3>\r\n");
#nullable restore
#line 7 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogLast3Post\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"blog-grids row mb-3\">\r\n            <div class=\"col-md-5 blog-grid-left\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 255, "\"", 289, 3);
            WriteAttributeValue("", 262, "/Blog/BlogReadAll/", 262, 18, true);
#nullable restore
#line 11 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogLast3Post\Default.cshtml"
WriteAttributeValue("", 280, item.ID, 280, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 288, "/", 288, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 317, "\"", 334, 1);
#nullable restore
#line 12 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogLast3Post\Default.cshtml"
WriteAttributeValue("", 323, item.Image, 323, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 366, "\"", 372, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </a>\r\n            </div>\r\n            <div class=\"col-md-7 blog-grid-right\">\r\n\r\n                <h5>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 516, "\"", 550, 3);
            WriteAttributeValue("", 523, "/Blog/BlogReadAll/", 523, 18, true);
#nullable restore
#line 18 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogLast3Post\Default.cshtml"
WriteAttributeValue("", 541, item.ID, 541, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 549, "/", 549, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 18 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogLast3Post\Default.cshtml"
                                                     Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </h5>\r\n                <div class=\"sub-meta\">\r\n                    <span>\r\n                        <i class=\"far fa-clock\"></i> ");
#nullable restore
#line 22 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogLast3Post\Default.cshtml"
                                                 Write(((DateTime)item.CreateDate).ToString("dd MMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </span>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n");
#nullable restore
#line 28 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogLast3Post\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591