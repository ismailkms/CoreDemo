#pragma checksum "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e761471e890651513b5c9cabe200fd63806f8cdb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_EditBlog), @"mvc.1.0.view", @"/Views/Blog/EditBlog.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e761471e890651513b5c9cabe200fd63806f8cdb", @"/Views/Blog/EditBlog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_EditBlog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Blog>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
  
    ViewData["Title"] = "EditBlog";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Blog Düzenleme Sayfası</h1>\r\n<br />\r\n");
#nullable restore
#line 11 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
 using (Html.BeginForm("EditBlog", "Blog", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.HiddenFor(x => x.AppUserId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.HiddenFor(x => x.CreateDate));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.HiddenFor(x => x.Status));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.HiddenFor(x => x.Image));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Başlık"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(x => x.Title, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.ValidationMessageFor(x => x.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 22 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Kategori"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.DropDownListFor(x => x.CategoryID, (List<SelectListItem>)ViewBag.cv, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 25 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.Label("İçerik"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.TextAreaFor(x => x.Content, 15, 3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.ValidationMessageFor(x => x.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-info\">Güncelle</button>\r\n");
#nullable restore
#line 30 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591