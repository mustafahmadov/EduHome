#pragma checksum "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Areas\Administrator\Views\Course\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "184e5902121d381d29905b3eae5c7fba1cd5547b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administrator_Views_Course_Detail), @"mvc.1.0.view", @"/Areas/Administrator/Views/Course/Detail.cshtml")]
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
#line 1 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Areas\Administrator\Views\_ViewImports.cshtml"
using EduHomeASPNET.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Areas\Administrator\Views\_ViewImports.cshtml"
using EduHomeASPNET.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"184e5902121d381d29905b3eae5c7fba1cd5547b", @"/Areas/Administrator/Views/Course/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41366fa82309204d03b1d51805af3c165e4cbae4", @"/Areas/Administrator/Views/_ViewImports.cshtml")]
    public class Areas_Administrator_Views_Course_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Course>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("300px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("150px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Areas\Administrator\Views\Course\Detail.cshtml"
   ViewData["Title"] = "Detail"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"row\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "184e5902121d381d29905b3eae5c7fba1cd5547b4956", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 82, "~/assets/img/course/", 82, 20, true);
#nullable restore
#line 5 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Areas\Administrator\Views\Course\Detail.cshtml"
AddHtmlAttributeValue("", 102, Model.Image, 102, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n<div class=\"row mt-5\">Name: ");
#nullable restore
#line 7 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Areas\Administrator\Views\Course\Detail.cshtml"
                       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n<div class=\"row mt-5\">Description: ");
#nullable restore
#line 8 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Areas\Administrator\Views\Course\Detail.cshtml"
                              Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n<div class=\"row mt-5\">Language: ");
#nullable restore
#line 9 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Areas\Administrator\Views\Course\Detail.cshtml"
                           Write(Model.CourseDetail.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n<div class=\"row mt-5\">SkillLevel: ");
#nullable restore
#line 10 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Areas\Administrator\Views\Course\Detail.cshtml"
                             Write(Model.CourseDetail.SkillLevel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n<div class=\"row mt-5\">StudentsCount: ");
#nullable restore
#line 11 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Areas\Administrator\Views\Course\Detail.cshtml"
                                Write(Model.CourseDetail.StudentsCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n<div class=\"row mt-5\">Duration: ");
#nullable restore
#line 12 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Areas\Administrator\Views\Course\Detail.cshtml"
                           Write(Model.CourseDetail.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n<div class=\"row mt-5\">About: ");
#nullable restore
#line 13 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Areas\Administrator\Views\Course\Detail.cshtml"
                        Write(Model.CourseDetail.About);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n<div class=\"row mt-5\">ApplyInfo: ");
#nullable restore
#line 14 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Areas\Administrator\Views\Course\Detail.cshtml"
                            Write(Model.CourseDetail.AboutApply);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n<div class=\"row mt-5\">CertificationInfo: ");
#nullable restore
#line 15 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Areas\Administrator\Views\Course\Detail.cshtml"
                                    Write(Model.CourseDetail.AboutCertification);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n<div class=\"row mt-5\">MainContent:  ");
#nullable restore
#line 16 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Areas\Administrator\Views\Course\Detail.cshtml"
                               Write(Model.CourseDetail.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n<div class=\"row mt-5\">ClassDuration: ");
#nullable restore
#line 17 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Areas\Administrator\Views\Course\Detail.cshtml"
                                Write(Model.CourseDetail.ClassDuration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n<div class=\"row mt-5\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "184e5902121d381d29905b3eae5c7fba1cd5547b10099", async() => {
                WriteLiteral("Go back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Course> Html { get; private set; }
    }
}
#pragma warning restore 1591
