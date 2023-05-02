#pragma checksum "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminBlog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7204666c4849aa6c5dbc014ce1bd8718181f7dc9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminBlog_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminBlog/Index.cshtml")]
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
#nullable restore
#line 2 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminBlog\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7204666c4849aa6c5dbc014ce1bd8718181f7dc9", @"/Areas/Admin/Views/AdminBlog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b881055197282d0a2ab51004156381e82f1e1fbc", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminBlog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminBlog\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7204666c4849aa6c5dbc014ce1bd8718181f7dc93759", async() => {
                WriteLiteral("\r\n    <div class=\"wrapper wrapper-content animated fadeInRight\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 16 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminBlog\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"col-md-3\">\r\n                    <div class=\"ibox\">\r\n                        <div class=\"ibox-content product-box\">\r\n\r\n                            <div>\r\n                                <img");
                BeginWriteAttribute("src", " src=\"", 546, "\"", 563, 1);
#nullable restore
#line 23 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminBlog\Index.cshtml"
WriteAttributeValue("", 552, item.Image, 552, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("  style=\"width: 100%;\"/>\r\n                            </div>\r\n                            <div class=\"product-desc\">\r\n                                <span class=\"product-price\">\r\n                                    ");
#nullable restore
#line 27 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminBlog\Index.cshtml"
                                Write(((DateTime)item.CreateDate).ToString("dd MMM yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </span>\r\n                                <small class=\"text-muted\">");
#nullable restore
#line 29 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminBlog\Index.cshtml"
                                                     Write(item.Category.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</small>\r\n                                <a href=\"#\" class=\"product-name\"> ");
#nullable restore
#line 30 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminBlog\Index.cshtml"
                                                             Write(item.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n\r\n\r\n\r\n                                <div class=\"small m-t-xs\">\r\n                                    ");
#nullable restore
#line 35 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminBlog\Index.cshtml"
                               Write(item.Content.Substring(0, item.Content.Substring(0, 100).LastIndexOf(" ")));

#line default
#line hidden
#nullable disable
                WriteLiteral("...\r\n                                </div>\r\n                                <div class=\"m-t text-righ\">\r\n\r\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 1370, "\"", 1403, 2);
                WriteAttributeValue("", 1377, "/Blog/BlogReadAll/", 1377, 18, true);
#nullable restore
#line 39 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminBlog\Index.cshtml"
WriteAttributeValue("", 1395, item.ID, 1395, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" target=\"_blank\" class=\"btn btn-xs btn-outline btn-primary\">Detaylar <i class=\"fa fa-long-arrow-right\"></i> </a>\r\n");
#nullable restore
#line 40 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminBlog\Index.cshtml"
                                     if (item.Status == true)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <a");
                BeginWriteAttribute("href", " href=\"", 1662, "\"", 1706, 2);
                WriteAttributeValue("", 1669, "/Admin/AdminBlog/MakePassive/", 1669, 29, true);
#nullable restore
#line 42 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminBlog\Index.cshtml"
WriteAttributeValue("", 1698, item.ID, 1698, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("  class=\"btn btn-xs btn-outline btn-danger\">Pasif Yap</a>\r\n");
#nullable restore
#line 43 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminBlog\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <a");
                BeginWriteAttribute("href", " href=\"", 1928, "\"", 1971, 2);
                WriteAttributeValue("", 1935, "/Admin/AdminBlog/MakeActive/", 1935, 28, true);
#nullable restore
#line 46 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminBlog\Index.cshtml"
WriteAttributeValue("", 1963, item.ID, 1963, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-xs btn-outline btn-info\">Aktif Yap</a>\r\n");
#nullable restore
#line 47 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminBlog\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 54 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminBlog\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n\r\n\r\n");
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
