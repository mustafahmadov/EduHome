#pragma checksum "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Teacher\TeacherDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c6b16222f8db5a073e38118edf903d48e2c4019"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_TeacherDetail), @"mvc.1.0.view", @"/Views/Teacher/TeacherDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c6b16222f8db5a073e38118edf903d48e2c4019", @"/Views/Teacher/TeacherDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59e172ea2a985a23bd5053064b1982bd06946788", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_TeacherDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Teacher>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("teacher"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Teacher\TeacherDetail.cshtml"
  
    ViewData["Title"] = "TeacherDetail";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Teacher Start -->
<div class=""teacher-details-area pt-150 pb-60"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-5 col-sm-5 col-xs-12"">
                <div class=""teacher-details-img"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1c6b16222f8db5a073e38118edf903d48e2c40194140", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 352, "~/assets/img/teacher/", 352, 21, true);
#nullable restore
#line 13 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Teacher\TeacherDetail.cshtml"
AddHtmlAttributeValue("", 373, Model.TeacherDetail.DetailedImage, 373, 34, false);

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
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-7 col-sm-7 col-xs-12\">\r\n                <div class=\"teacher-details-content ml-50\">\r\n                    <h2>");
#nullable restore
#line 18 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Teacher\TeacherDetail.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 18 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Teacher\TeacherDetail.cshtml"
                                Write(Model.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <h5>");
#nullable restore
#line 19 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Teacher\TeacherDetail.cshtml"
                   Write(Model.Profession);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <h4>about me</h4>\r\n                    <p>");
#nullable restore
#line 21 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Teacher\TeacherDetail.cshtml"
                  Write(Model.TeacherDetail.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <ul>\r\n                        <li><span>degree: </span> ");
#nullable restore
#line 23 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Teacher\TeacherDetail.cshtml"
                                             Write(Model.TeacherDetail.Degree);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li><span>experience: </span> ");
#nullable restore
#line 24 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Teacher\TeacherDetail.cshtml"
                                                 Write(Model.TeacherDetail.Experience);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li><span>hobbies: </span> ");
#nullable restore
#line 25 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Teacher\TeacherDetail.cshtml"
                                              Write(Model.TeacherDetail.Hobbies);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li><span>faculty: </span> ");
#nullable restore
#line 26 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Teacher\TeacherDetail.cshtml"
                                              Write(Model.TeacherDetail.Faculty);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                    </ul>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-3 col-sm-4"">
                <div class=""teacher-contact"">
                    <h4>contact information</h4>
                    <p><span>mail me : </span> ");
#nullable restore
#line 35 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Teacher\TeacherDetail.cshtml"
                                          Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p><span>make a call : </span> ");
#nullable restore
#line 36 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Teacher\TeacherDetail.cshtml"
                                              Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p><span>skype : </span>  ");
#nullable restore
#line 37 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Teacher\TeacherDetail.cshtml"
                                         Write(Model.Skype);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <ul>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 1675, "\"", 1697, 1);
#nullable restore
#line 39 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Teacher\TeacherDetail.cshtml"
WriteAttributeValue("", 1682, Model.Facebook, 1682, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"zmdi zmdi-facebook\"></i></a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 1774, "\"", 1797, 1);
#nullable restore
#line 40 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Teacher\TeacherDetail.cshtml"
WriteAttributeValue("", 1781, Model.Pinterest, 1781, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"zmdi zmdi-pinterest\"></i></a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 1875, "\"", 1894, 1);
#nullable restore
#line 41 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Teacher\TeacherDetail.cshtml"
WriteAttributeValue("", 1882, Model.Vimeo, 1882, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"zmdi zmdi-vimeo\"></i></a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 1968, "\"", 1989, 1);
#nullable restore
#line 42 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Teacher\TeacherDetail.cshtml"
WriteAttributeValue("", 1975, Model.Twitter, 1975, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><i class=""zmdi zmdi-twitter""></i></a></li>
                    </ul>
                </div>
            </div>
            <div class=""col-md-9 col-sm-8"">
                <div class=""skill-area"">
                    <h4>skills</h4>
                </div>
                <div class=""skill-wrapper"">
                    <div class=""row"">
");
#nullable restore
#line 52 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Teacher\TeacherDetail.cshtml"
                         for (int i = 0; i <= 5; i++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""col-sm-4"">
                                <div class=""skill-bar-item"">
                                    <span>language</span>
                                    <div class=""progress"">
                                        <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            BeginWriteAttribute("style", " style=\"", 2744, "\"", 2880, 11);
            WriteAttributeValue("", 2752, "width:", 2752, 6, true);
#nullable restore
#line 58 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Teacher\TeacherDetail.cshtml"
WriteAttributeValue(" ", 2758, Model.Skill.Language, 2759, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2780, "%;", 2780, 2, true);
            WriteAttributeValue(" ", 2782, "visibility:", 2783, 12, true);
            WriteAttributeValue(" ", 2794, "visible;", 2795, 9, true);
            WriteAttributeValue(" ", 2803, "animation-duration:", 2804, 20, true);
            WriteAttributeValue(" ", 2823, "1.5s;", 2824, 6, true);
            WriteAttributeValue(" ", 2829, "animation-delay:", 2830, 17, true);
            WriteAttributeValue(" ", 2846, "1.2s;", 2847, 6, true);
            WriteAttributeValue(" ", 2852, "animation-name:", 2853, 16, true);
            WriteAttributeValue(" ", 2868, "fadeInLeft;", 2869, 12, true);
            EndWriteAttribute();
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                                            <span class=\"text-top\">");
#nullable restore
#line 59 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Teacher\TeacherDetail.cshtml"
                                                              Write(Model.Skill.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 64 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Teacher\TeacherDetail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- Teacher End -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Teacher> Html { get; private set; }
    }
}
#pragma warning restore 1591