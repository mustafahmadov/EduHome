#pragma checksum "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28977c1885143b8d72d328334609ace6c1d82175"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28977c1885143b8d72d328334609ace6c1d82175", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59e172ea2a985a23bd5053064b1982bd06946788", @"/Views/_ViewImports.cshtml")]
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("about"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/icon/section.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("title"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\About\Index.cshtml"
   
    ViewData["Title"] = "About Us"; 
 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<!-- About Start -->\n<div class=\"about-area pt-145 pb-155\">\n    <div class=\"container\">\n        <div class=\"row\">\n            <div class=\"col-md-6 col-sm-6\">\n                <div class=\"about-content\">\n                    <h2>");
#nullable restore
#line 13 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\About\Index.cshtml"
                   Write(Model.About.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h2>\n                    <p>");
#nullable restore
#line 14 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\About\Index.cshtml"
                  Write(Model.About.FirstContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <p class=\"hidden-sm\">");
#nullable restore
#line 15 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\About\Index.cshtml"
                                    Write(Model.About.SecondContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <a class=\"default-btn\" href=\"#\">view courses</a>\n                </div>\n            </div>\n            <div class=\"col-md-6 col-sm-6\">\n                <div class=\"about-img\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "28977c1885143b8d72d328334609ace6c1d821755778", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 667, "~/assets/img/about/", 667, 19, true);
#nullable restore
#line 21 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\About\Index.cshtml"
AddHtmlAttributeValue("", 686, Model.About.Image, 686, 18, false);

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
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>
</div>
<!-- About End -->

<!-- Teacher Start -->
<div class=""teacher-area pb-150"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <div class=""section-title text-center"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "28977c1885143b8d72d328334609ace6c1d821757671", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    <h2>meet our teachers</h2>\n                </div>\n            </div>\n        </div>\n        <div class=\"row\">\n            ");
#nullable restore
#line 41 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\About\Index.cshtml"
       Write(await Component.InvokeAsync("Teacher", 4));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n</div>\n<!-- Teacher End -->\n\n<!-- Testimonial Area Start -->\n");
#nullable restore
#line 48 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\About\Index.cshtml"
Write(await Component.InvokeAsync("Testimonial"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" 
<!-- Testimonial Area End -->

<!-- Notice Start -->
<section class=""notice-area two pt-140 pb-100"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6 col-sm-6 col-xs-12"">
                <div class=""notice-right-wrapper mb-25 pb-25"">
                    <h3>");
#nullable restore
#line 57 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\About\Index.cshtml"
                   Write(Model.Video.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                    <div class=\"notice-video\">\n                        <div class=\"video-icon video-hover\">\n                            <a class=\"video-popup\"");
            BeginWriteAttribute("href", " href=\"", 1886, "\"", 1915, 1);
#nullable restore
#line 60 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\About\Index.cshtml"
WriteAttributeValue("", 1893, Model.Video.VideoLink, 1893, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                <i class=\"zmdi zmdi-play\"></i>\n                            </a>\n                        </div>\n                    </div>\n                </div>\n            </div>\n            ");
#nullable restore
#line 67 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\About\Index.cshtml"
       Write(await Component.InvokeAsync("Notice",6));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n</section>\n<!-- Notice End -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
