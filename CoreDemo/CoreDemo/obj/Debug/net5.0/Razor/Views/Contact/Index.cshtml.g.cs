#pragma checksum "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9459185a96505d78f5047bef245cc26913ec8206"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9459185a96505d78f5047bef245cc26913ec8206", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/CoreBlogTema/css/contact.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\lenovopc\source\repos\CoreDemo\CoreDemo\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"zxx\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9459185a96505d78f5047bef245cc26913ec82065329", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9459185a96505d78f5047bef245cc26913ec82065591", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9459185a96505d78f5047bef245cc26913ec82067560", async() => {
                WriteLiteral(@"
    <!--/main-->
    <section class=""main-content-w3layouts-agileits"">

        <h3 class=""tittle"">Bize Ulaşın</h3>
        <p class=""sub text-center"">DÜŞÜNCELERNİZ BİZİM İÇİN ÇOK KIYMETLİ</p>
        <div class=""contact-map inner-sec"">

            <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d770851.7549276184!2d27.829600340301006!3d41.000316120979164!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14caa7040068086b%3A0xe1ccfe98bc01b0d0!2zxLBzdGFuYnVsLCBUw7xya2l5ZQ!5e0!3m2!1str!2sus!4v1682959212594!5m2!1str!2sus"" width=""600"" height=""450"" style=""border:0;""");
                BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 837, "\"", 855, 0);
                EndWriteAttribute();
                WriteLiteral(" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"\r\n                    class=\"map\" style=\"border:0\"");
                BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 965, "\"", 983, 0);
                EndWriteAttribute();
                WriteLiteral(@"></iframe>
        </div>
        <div class=""ad-inf-sec bg-light"">
            <div class=""container"">
                <div class=""address row"">

                    <div class=""col-lg-4 address-grid"">
                        <div class=""row address-info"">
                            <div class=""col-md-4 address-left text-center"">
                                <i class=""far fa-map""></i>
                            </div>
                            <div class=""col-md-8 address-right text-left"">
                                <h6>Adres</h6>
                                <p>
                                    İstanbul, Türkiye

                                </p>
                            </div>
                        </div>

                    </div>
                    <div class=""col-lg-4 address-grid"">
                        <div class=""row address-info"">
                            <div class=""col-md-4 address-left text-center"">
                                <i class=");
                WriteLiteral(@"""far fa-envelope""></i>
                            </div>
                            <div class=""col-md-8 address-right text-left"">
                                <h6>Mail</h6>
                                <p>
                                    <a href=""mailto:example@email.com""> blog@example.com</a>

                                </p>
                            </div>

                        </div>
                    </div>
                    <div class=""col-lg-4 address-grid"">
                        <div class=""row address-info"">
                            <div class=""col-md-4 address-left text-center"">
                                <i class=""fas fa-mobile-alt""></i>
                            </div>
                            <div class=""col-md-8 address-right text-left"">
                                <h6>Telefon</h6>
                                <p>+90 234 567 8901</p>

                            </div>

                        </div>
                    </di");
                WriteLiteral("v>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"container\">\r\n            <div class=\"contact_grid_right\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9459185a96505d78f5047bef245cc26913ec820611223", async() => {
                    WriteLiteral(@"
                    <div class=""row contact_left_grid"">
                        <div class=""col-md-6 con-left"">
                            <div class=""form-group"">
                                <label for=""validationCustom01 my-2"">Adınız</label>
                                <input class=""form-control"" type=""text"" name=""UserName""");
                    BeginWriteAttribute("placeholder", " placeholder=\"", 3553, "\"", 3567, 0);
                    EndWriteAttribute();
                    BeginWriteAttribute("required", " required=\"", 3568, "\"", 3579, 0);
                    EndWriteAttribute();
                    WriteLiteral(@">
                            </div>
                            <div class=""form-group"">
                                <label for=""exampleFormControlInput1"">Mail Adresiniz</label>
                                <input class=""form-control"" type=""email"" name=""Mail""");
                    BeginWriteAttribute("placeholder", " placeholder=\"", 3851, "\"", 3865, 0);
                    EndWriteAttribute();
                    BeginWriteAttribute("required", " required=\"", 3866, "\"", 3877, 0);
                    EndWriteAttribute();
                    WriteLiteral(@">
                            </div>
                            <div class=""form-group"">
                                <label for=""validationCustom03 my-2"">Konu</label>
                                <input class=""form-control"" type=""text"" name=""Subject""");
                    BeginWriteAttribute("placeholder", " placeholder=\"", 4140, "\"", 4154, 0);
                    EndWriteAttribute();
                    BeginWriteAttribute("required", " required=\"", 4155, "\"", 4166, 0);
                    EndWriteAttribute();
                    WriteLiteral(@">
                            </div>
                        </div>
                        <div class=""col-md-6 con-right"">
                            <div class=""form-group"">
                                <label for=""textarea"">Mesajınız</label>
                                <textarea id=""textarea"" name=""Message""");
                    BeginWriteAttribute("placeholder", " placeholder=\"", 4493, "\"", 4507, 0);
                    EndWriteAttribute();
                    WriteLiteral("></textarea>\r\n                            </div>\r\n                            <input class=\"form-control\" type=\"submit\" value=\"Gönder\">\r\n\r\n                        </div>\r\n                    </div>\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </section>\r\n    <!--//main-->\r\n");
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
            WriteLiteral("\r\n\r\n</html>\r\n\r\n");
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
