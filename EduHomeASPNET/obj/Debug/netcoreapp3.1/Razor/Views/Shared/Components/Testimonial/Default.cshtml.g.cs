#pragma checksum "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Shared\Components\Testimonial\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "781a347dcce55525a9e416a45adfd91b7d3be64b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Testimonial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Testimonial/Default.cshtml")]
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
#line 1 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\_ViewImports.cshtml"
using EduHomeASPNET;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\_ViewImports.cshtml"
using EduHomeASPNET.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\_ViewImports.cshtml"
using EduHomeASPNET.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"781a347dcce55525a9e416a45adfd91b7d3be64b", @"/Views/Shared/Components/Testimonial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09b8471a206536acdaef34352f1ddeb3d6cfb18f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Testimonial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<StudentComment>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("testimonial"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"testimonial-area pt-110 pb-105 text-center\">\n    <div class=\"container\">\n        <div class=\"row\">\n            <div class=\"testimonial-owl owl-theme owl-carousel\">\n");
#nullable restore
#line 7 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Shared\Components\Testimonial\Default.cshtml"
                 foreach (StudentComment comment in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-md-8 col-md-offset-2 col-sm-12"">

                        <div class=""single-testimonial"">
                            <div class=""testimonial-info"">
                                <div class=""testimonial-img"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "781a347dcce55525a9e416a45adfd91b7d3be64b4884", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 576, "~/assets/img/testimonial/", 576, 25, true);
#nullable restore
#line 14 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Shared\Components\Testimonial\Default.cshtml"
AddHtmlAttributeValue("", 601, comment.Student.Image, 601, 22, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                </div>\n                                <div class=\"testimonial-content\">\n                                    <p>");
#nullable restore
#line 17 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Shared\Components\Testimonial\Default.cshtml"
                                  Write(comment.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                    <h4>");
#nullable restore
#line 18 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Shared\Components\Testimonial\Default.cshtml"
                                   Write(comment.Student.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 18 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Shared\Components\Testimonial\Default.cshtml"
                                                         Write(comment.Student.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n                                    <h5>Student, CSE</h5>\n                                </div>\n                            </div>\n                        </div>\n                        \n\n                    </div>\n");
#nullable restore
#line 26 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Shared\Components\Testimonial\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<StudentComment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
