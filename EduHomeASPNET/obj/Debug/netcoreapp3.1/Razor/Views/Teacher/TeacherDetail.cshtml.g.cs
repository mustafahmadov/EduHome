#pragma checksum "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Teacher\TeacherDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7020ad72233fd554205d382921de3db29e998c53"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7020ad72233fd554205d382921de3db29e998c53", @"/Views/Teacher/TeacherDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09b8471a206536acdaef34352f1ddeb3d6cfb18f", @"/Views/_ViewImports.cshtml")]
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7020ad72233fd554205d382921de3db29e998c534514", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 352, "~/assets/img/teacher/", 352, 21, true);
#nullable restore
#line 13 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Teacher\TeacherDetail.cshtml"
AddHtmlAttributeValue("", 373, Model.Image, 373, 12, false);

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
            BeginWriteAttribute("href", " href=\"", 1653, "\"", 1675, 1);
#nullable restore
#line 39 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Teacher\TeacherDetail.cshtml"
WriteAttributeValue("", 1660, Model.Facebook, 1660, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"zmdi zmdi-facebook\"></i></a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 1752, "\"", 1775, 1);
#nullable restore
#line 40 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Teacher\TeacherDetail.cshtml"
WriteAttributeValue("", 1759, Model.Pinterest, 1759, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"zmdi zmdi-pinterest\"></i></a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 1853, "\"", 1872, 1);
#nullable restore
#line 41 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Teacher\TeacherDetail.cshtml"
WriteAttributeValue("", 1860, Model.Vimeo, 1860, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"zmdi zmdi-vimeo\"></i></a></li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 1946, "\"", 1967, 1);
#nullable restore
#line 42 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Teacher\TeacherDetail.cshtml"
WriteAttributeValue("", 1953, Model.Twitter, 1953, 14, false);

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
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>language</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            BeginWriteAttribute("style", " style=\"", 2620, "\"", 2756, 11);
            WriteAttributeValue("", 2628, "width:", 2628, 6, true);
#nullable restore
#line 56 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Teacher\TeacherDetail.cshtml"
WriteAttributeValue(" ", 2634, Model.Skill.Language, 2635, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2656, "%;", 2656, 2, true);
            WriteAttributeValue(" ", 2658, "visibility:", 2659, 12, true);
            WriteAttributeValue(" ", 2670, "visible;", 2671, 9, true);
            WriteAttributeValue(" ", 2679, "animation-duration:", 2680, 20, true);
            WriteAttributeValue(" ", 2699, "1.5s;", 2700, 6, true);
            WriteAttributeValue(" ", 2705, "animation-delay:", 2706, 17, true);
            WriteAttributeValue(" ", 2722, "1.2s;", 2723, 6, true);
            WriteAttributeValue(" ", 2728, "animation-name:", 2729, 16, true);
            WriteAttributeValue(" ", 2744, "fadeInLeft;", 2745, 12, true);
            EndWriteAttribute();
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                                        <span class=\"text-top\">");
#nullable restore
#line 57 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Teacher\TeacherDetail.cshtml"
                                                          Write(Model.Skill.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>language</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            BeginWriteAttribute("style", " style=\"", 3366, "\"", 3504, 11);
            WriteAttributeValue("", 3374, "width:", 3374, 6, true);
#nullable restore
#line 66 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Teacher\TeacherDetail.cshtml"
WriteAttributeValue(" ", 3380, Model.Skill.TeamLeader, 3381, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3404, "%;", 3404, 2, true);
            WriteAttributeValue(" ", 3406, "visibility:", 3407, 12, true);
            WriteAttributeValue(" ", 3418, "visible;", 3419, 9, true);
            WriteAttributeValue(" ", 3427, "animation-duration:", 3428, 20, true);
            WriteAttributeValue(" ", 3447, "1.5s;", 3448, 6, true);
            WriteAttributeValue(" ", 3453, "animation-delay:", 3454, 17, true);
            WriteAttributeValue(" ", 3470, "1.2s;", 3471, 6, true);
            WriteAttributeValue(" ", 3476, "animation-name:", 3477, 16, true);
            WriteAttributeValue(" ", 3492, "fadeInLeft;", 3493, 12, true);
            EndWriteAttribute();
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                                        <span class=\"text-top\">");
#nullable restore
#line 67 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Teacher\TeacherDetail.cshtml"
                                                          Write(Model.Skill.TeamLeader);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>language</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            BeginWriteAttribute("style", " style=\"", 4116, "\"", 4255, 11);
            WriteAttributeValue("", 4124, "width:", 4124, 6, true);
#nullable restore
#line 76 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Teacher\TeacherDetail.cshtml"
WriteAttributeValue(" ", 4130, Model.Skill.Development, 4131, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4155, "%;", 4155, 2, true);
            WriteAttributeValue(" ", 4157, "visibility:", 4158, 12, true);
            WriteAttributeValue(" ", 4169, "visible;", 4170, 9, true);
            WriteAttributeValue(" ", 4178, "animation-duration:", 4179, 20, true);
            WriteAttributeValue(" ", 4198, "1.5s;", 4199, 6, true);
            WriteAttributeValue(" ", 4204, "animation-delay:", 4205, 17, true);
            WriteAttributeValue(" ", 4221, "1.2s;", 4222, 6, true);
            WriteAttributeValue(" ", 4227, "animation-name:", 4228, 16, true);
            WriteAttributeValue(" ", 4243, "fadeInLeft;", 4244, 12, true);
            EndWriteAttribute();
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                                        <span class=\"text-top\">");
#nullable restore
#line 77 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Teacher\TeacherDetail.cshtml"
                                                          Write(Model.Skill.Development);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>language</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            BeginWriteAttribute("style", " style=\"", 4868, "\"", 5002, 11);
            WriteAttributeValue("", 4876, "width:", 4876, 6, true);
#nullable restore
#line 86 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Teacher\TeacherDetail.cshtml"
WriteAttributeValue(" ", 4882, Model.Skill.Design, 4883, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4902, "%;", 4902, 2, true);
            WriteAttributeValue(" ", 4904, "visibility:", 4905, 12, true);
            WriteAttributeValue(" ", 4916, "visible;", 4917, 9, true);
            WriteAttributeValue(" ", 4925, "animation-duration:", 4926, 20, true);
            WriteAttributeValue(" ", 4945, "1.5s;", 4946, 6, true);
            WriteAttributeValue(" ", 4951, "animation-delay:", 4952, 17, true);
            WriteAttributeValue(" ", 4968, "1.2s;", 4969, 6, true);
            WriteAttributeValue(" ", 4974, "animation-name:", 4975, 16, true);
            WriteAttributeValue(" ", 4990, "fadeInLeft;", 4991, 12, true);
            EndWriteAttribute();
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                                        <span class=\"text-top\">");
#nullable restore
#line 87 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Teacher\TeacherDetail.cshtml"
                                                          Write(Model.Skill.Design);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>language</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            BeginWriteAttribute("style", " style=\"", 5610, "\"", 5751, 11);
            WriteAttributeValue("", 5618, "width:", 5618, 6, true);
#nullable restore
#line 96 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Teacher\TeacherDetail.cshtml"
WriteAttributeValue(" ", 5624, Model.Skill.Communication, 5625, 26, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5651, "%;", 5651, 2, true);
            WriteAttributeValue(" ", 5653, "visibility:", 5654, 12, true);
            WriteAttributeValue(" ", 5665, "visible;", 5666, 9, true);
            WriteAttributeValue(" ", 5674, "animation-duration:", 5675, 20, true);
            WriteAttributeValue(" ", 5694, "1.5s;", 5695, 6, true);
            WriteAttributeValue(" ", 5700, "animation-delay:", 5701, 17, true);
            WriteAttributeValue(" ", 5717, "1.2s;", 5718, 6, true);
            WriteAttributeValue(" ", 5723, "animation-name:", 5724, 16, true);
            WriteAttributeValue(" ", 5739, "fadeInLeft;", 5740, 12, true);
            EndWriteAttribute();
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                                        <span class=\"text-top\">");
#nullable restore
#line 97 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Teacher\TeacherDetail.cshtml"
                                                          Write(Model.Skill.Communication);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>language</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            BeginWriteAttribute("style", " style=\"", 6366, "\"", 6504, 11);
            WriteAttributeValue("", 6374, "width:", 6374, 6, true);
#nullable restore
#line 106 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Teacher\TeacherDetail.cshtml"
WriteAttributeValue(" ", 6380, Model.Skill.Innovation, 6381, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6404, "%;", 6404, 2, true);
            WriteAttributeValue(" ", 6406, "visibility:", 6407, 12, true);
            WriteAttributeValue(" ", 6418, "visible;", 6419, 9, true);
            WriteAttributeValue(" ", 6427, "animation-duration:", 6428, 20, true);
            WriteAttributeValue(" ", 6447, "1.5s;", 6448, 6, true);
            WriteAttributeValue(" ", 6453, "animation-delay:", 6454, 17, true);
            WriteAttributeValue(" ", 6470, "1.2s;", 6471, 6, true);
            WriteAttributeValue(" ", 6476, "animation-name:", 6477, 16, true);
            WriteAttributeValue(" ", 6492, "fadeInLeft;", 6493, 12, true);
            EndWriteAttribute();
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\r\n                                        <span class=\"text-top\">");
#nullable restore
#line 107 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Teacher\TeacherDetail.cshtml"
                                                          Write(Model.Skill.Innovation);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Teacher End -->
");
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
