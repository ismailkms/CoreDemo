#pragma checksum "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Views\Admin\AdminNavbarPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b9e2626a0ce82a388d2970ccb3f37c12199cc5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AdminNavbarPartial), @"mvc.1.0.view", @"/Views/Admin/AdminNavbarPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b9e2626a0ce82a388d2970ccb3f37c12199cc5c", @"/Views/Admin/AdminNavbarPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AdminNavbarPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<nav class=\"navbar-default navbar-static-side\" role=\"navigation\">\r\n    <div class=\"sidebar-collapse\">\r\n        <ul class=\"nav metismenu\" id=\"side-menu\">\r\n            <li class=\"nav-header\">\r\n\r\n                ");
#nullable restore
#line 6 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Views\Admin\AdminNavbarPartial.cshtml"
           Write(await Component.InvokeAsync("AdminUser"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                <div class=""logo-element"">
                    Blog Core
                </div>
            </li>
            <li>
                <a href=""/Admin/Widget/Index/""><i class=""fa fa-th-large""></i> <span class=""nav-label"">Dashboard</span></a>
            </li>
            <li>
                <a href=""/Admin/Chart/Index/""><i class=""fa fa-bar-chart-o""></i> <span class=""nav-label"">Grafikler</span></a>
            </li>
            <li>
                <a href=""/Admin/AdminMessage/InBox/""><i class=""fa fa-envelope""></i> <span class=""nav-label"">Mesajlar </span></a>
            </li>
            <li>
                <a href=""/Admin/Category/Index/""><i class=""fa fa-group""></i> <span class=""nav-label"">Kategoriler</span>  </a>
            </li>
            <li>
                <a href=""/Admin/AdminBlog/Index/""><i class=""fa fa-list-alt""></i> <span class=""nav-label"">Bloglar</span>  </a>
            </li>
            <li>
                <a href=""/Admin/AdminComment/Index/""><i class=""fa");
            WriteLiteral(@" fa-comment""></i> <span class=""nav-label"">Yorumlar</span>  </a>
            </li>
            <li>
                <a href=""/Admin/Writer/Index/""><i class=""fa fa-user""></i> <span class=""nav-label"">Yazarlar</span>  </a>
            </li>
            <li>
                <a href=""/Admin/AdminRol/Index/""><i class=""fa fa-random""></i> <span class=""nav-label"">Roller</span>  </a>
            </li>
            <li>
                <a href=""/Admin/AdminNotification/Index/""><i class=""fa fa-bell""></i> <span class=""nav-label"">Bildirimler</span>  </a>
            </li>
            <li>
                <a href=""/Admin/AdminContact/Index/""><i class=""fa fa-phone""></i> <span class=""nav-label"">İletişim</span>  </a>
            </li>
            <li>
                <a href=""/Admin/AdminAbout/Index/""><i class=""fa fa-address-book""></i> <span class=""nav-label"">Hakkımızda</span>  </a>
            </li>
            <li>
                <a href=""/Admin/Blog/BlogTitleListExcel/""><i class=""fa fa-table""></i> <span cla");
            WriteLiteral("ss=\"nav-label\">Excel İşlemleri</span></a>\r\n            </li>\r\n            <li>\r\n                <a href=\"/Login/LogOut/\"><i class=\"fa fa-sign-out\"></i> <span class=\"nav-label\">Çıkış Yap</span>  </a>\r\n            </li>\r\n        </ul>\r\n\r\n    </div>\r\n</nav>");
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
