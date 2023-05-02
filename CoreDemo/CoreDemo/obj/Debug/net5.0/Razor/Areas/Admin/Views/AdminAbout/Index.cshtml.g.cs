#pragma checksum "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminAbout\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb8f872a201b40781f56e7fd2e4b10f7425d1bd2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminAbout_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminAbout/Index.cshtml")]
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
#line 2 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminAbout\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb8f872a201b40781f56e7fd2e4b10f7425d1bd2", @"/Areas/Admin/Views/AdminAbout/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b881055197282d0a2ab51004156381e82f1e1fbc", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminAbout_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<About>>
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
#line 5 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminAbout\Index.cshtml"
      
        ViewData["Title"] = "Index";
        Layout = "~/Views/Shared/AdminLayout.cshtml";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <!DOCTYPE html>\r\n    <html>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb8f872a201b40781f56e7fd2e4b10f7425d1bd23797", async() => {
                WriteLiteral(@"
        <div class=""wrapper wrapper-content animated fadeInRight"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""ibox "">
                        <div class=""ibox-title"">
                            <h5>Hakkımızda </h5>
                            <div class=""ibox-tools"">
                                <a class=""collapse-link"">
                                    <i class=""fa fa-chevron-up""></i>
                                </a>
                            </div>
                        </div>
                        <div class=""ibox-content"">

                            <table class=""table table-hover"">
                                <thead>
                                    <tr>
                                        <th>#</th>
                                        <th>Başlık</th>
                                        <th>Düzenle</th>
                                    </tr>
                                </thead>
");
                WriteLiteral("                                <tbody>\r\n");
#nullable restore
#line 37 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminAbout\Index.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <tr>\r\n                                            <th>");
#nullable restore
#line 40 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminAbout\Index.cshtml"
                                           Write(item.ID);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                            <td>");
#nullable restore
#line 41 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminAbout\Index.cshtml"
                                           Write(item.Details2);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                            <td><a");
                BeginWriteAttribute("href", " href=\"", 1606, "\"", 1651, 2);
                WriteAttributeValue("", 1613, "/Admin/AdminAbout/UpdateAbout/", 1613, 30, true);
#nullable restore
#line 42 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminAbout\Index.cshtml"
WriteAttributeValue("", 1643, item.ID, 1643, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-warning\">Düzenle</a></td>\r\n                                        </tr>\r\n");
#nullable restore
#line 44 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\AdminAbout\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<About>> Html { get; private set; }
    }
}
#pragma warning restore 1591
