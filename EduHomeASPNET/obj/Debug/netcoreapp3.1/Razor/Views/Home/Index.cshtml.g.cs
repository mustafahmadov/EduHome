#pragma checksum "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ff872927d9001086d3db835d3a4b954b86a5525"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ff872927d9001086d3db835d3a4b954b86a5525", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09b8471a206536acdaef34352f1ddeb3d6cfb18f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("default-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Course", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/icon/section.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("section-title"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    int count = 0;


#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- Background Area Start -->\n<section id=\"slider-container\" class=\"slider-area\">\n    <div class=\"slider-owl owl-theme owl-carousel\">\n");
#nullable restore
#line 10 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Home\Index.cshtml"
         foreach (Slider slider in Model.Sliders)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <!-- Start Slingle Slide -->\n            <div class=\"single-slide item\"");
            BeginWriteAttribute("style", " style=\"", 350, "\"", 412, 4);
            WriteAttributeValue("", 358, "background-image:", 358, 17, true);
            WriteAttributeValue(" ", 375, "url(assets/img/slider/", 376, 23, true);
#nullable restore
#line 13 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Home\Index.cshtml"
WriteAttributeValue("", 398, slider.Image, 398, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 411, ")", 411, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
                <!-- Start Slider Content -->
                <div class=""slider-content-area"">
                    <div class=""container"">
                        <div class=""row"">
                            <div class=""col-md-7 col-md-offset-left-5"">
                                <div class=""slide-content-wrapper"">
                                    <div class=""slide-content"">
                                        ");
#nullable restore
#line 21 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Home\Index.cshtml"
                                   Write(Html.Raw(slider.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        <p>");
#nullable restore
#line 22 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Home\Index.cshtml"
                                      Write(slider.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ff872927d9001086d3db835d3a4b954b86a55258008", async() => {
                WriteLiteral("Learn more");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
                </div>
                <!-- Start Slider Content -->
            </div>
            <!-- End Slingle Slide -->
");
#nullable restore
#line 33 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</section>\n<!-- Background Area End -->\n\n<!-- Notice Start -->\n<section class=\"notice-area pt-150 pb-150\">\n    <div class=\"container\">\n        <div class=\"row\">\n            ");
#nullable restore
#line 42 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Home\Index.cshtml"
       Write(await Component.InvokeAsync("Notice", 9));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <div class=\"col-md-6 col-sm-6 col-xs-12\">\n                <div class=\"notice-right\">\n");
#nullable restore
#line 45 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Home\Index.cshtml"
                     foreach (RightNotice rn in Model.RightNotices)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"single-notice-right mb-25 pb-20\">\n            <h3>");
#nullable restore
#line 48 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Home\Index.cshtml"
           Write(rn.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n            <p>");
#nullable restore
#line 49 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Home\Index.cshtml"
          Write(rn.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        </div>");
#nullable restore
#line 50 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Home\Index.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div>
</section>
<!-- Notice End -->

<!-- Choose Start -->
<section class=""choose-area pb-85 pt-77"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-8 col-md-offset-left-4 col-sm-8 col-md-offset-left-4"">
                <div class=""choose-content text-left"">
                    <h2>");
#nullable restore
#line 64 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Home\Index.cshtml"
                   Write(Model.Choose.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n                    <p>");
#nullable restore
#line 65 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Home\Index.cshtml"
                  Write(Model.Choose.FirstContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <p class=\"choose-option\">");
#nullable restore
#line 66 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Home\Index.cshtml"
                                        Write(Model.Choose.SecondContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ff872927d9001086d3db835d3a4b954b86a552512714", async() => {
                WriteLiteral("view courses");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
</section>
<!-- Choose Area End -->

<!-- Courses Area Start -->
<div class=""courses-area pt-150 text-center"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <div class=""section-title"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2ff872927d9001086d3db835d3a4b954b86a552514506", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    <h2>COURSES WE OFFER</h2>\n                </div>\n            </div>\n        </div>\n        <div class=\"row\">\n            ");
#nullable restore
#line 87 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Home\Index.cshtml"
       Write(await Component.InvokeAsync("Course",new { page = 1,take=3}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
    </div>
</div>
<!-- Courses Area End -->

<!-- Event Area Start -->
<div class=""event-area one text-center pt-140 pb-150"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <div class=""section-title"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2ff872927d9001086d3db835d3a4b954b86a552516332", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    <h2>UPCOMMING EVENTS</h2>\n                </div>\n            </div>\n        </div>\n        <div class=\"row\">\n            <div class=\"col-md-6 col-sm-12 col-xs-12\">\n");
#nullable restore
#line 106 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Home\Index.cshtml"
                 foreach (Event ev in Model.Events)
                {
                   
                    if (count % 4 == 0 && count != 0)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 111 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Home\Index.cshtml"
                   Write(Html.Raw("</div><div class='col-md-6 hidden-sm hidden-xs'>"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 111 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Home\Index.cshtml"
                                                                                     
                    }
       

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"single-event mb-35\">\n                            <div class=\"event-date\">\n                                <h3>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ff872927d9001086d3db835d3a4b954b86a552518672", async() => {
                WriteLiteral("18 <span>June</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h3>\n                            </div>\n                            <div class=\"event-content text-left\">\n                                <div class=\"event-content-left\">\n                                    <h4>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ff872927d9001086d3db835d3a4b954b86a552520264", async() => {
#nullable restore
#line 120 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Home\Index.cshtml"
                                                                               Write(ev.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h4>\n                                    <ul>\n                                        <li><i class=\"fa fa-clock-o\"></i>");
#nullable restore
#line 122 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Home\Index.cshtml"
                                                                    Write(ev.StartTime.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 122 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Home\Index.cshtml"
                                                                                                      Write(ev.EndTime.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                                        <li><i class=\"fa fa-map-marker\"></i>");
#nullable restore
#line 123 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Home\Index.cshtml"
                                                                       Write(ev.PlacedArea);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                                    </ul>\n                                </div>\n                                <div class=\"event-content-right\">\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ff872927d9001086d3db835d3a4b954b86a552523123", async() => {
                WriteLiteral("join now");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                </div>\n                            </div>\n                        </div>\n");
#nullable restore
#line 131 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Home\Index.cshtml"
                    count++;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n        </div>\n    </div>\n</div>\n<!-- Event Area End -->\n\n<!-- Testimonial Area Start -->\n");
#nullable restore
#line 140 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("Testimonial"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Testimonial Area End -->

<!-- Blog Area Start -->
<div class=""blog-area pt-150 pb-150"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <div class=""section-title text-center"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2ff872927d9001086d3db835d3a4b954b86a552525527", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    <h2>LATEST FROM BLOG</h2>\n                </div>\n            </div>\n        </div>\n        <div class=\"row\">\n            ");
#nullable restore
#line 155 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Home\Index.cshtml"
       Write(await Component.InvokeAsync("Blog",new { page=1,take=3}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n</div>\n<!-- Blog Area End -->\n\n");
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
