#pragma checksum "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7fd9b439368dca5fb0c0b94740df6b59361791c"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7fd9b439368dca5fb0c0b94740df6b59361791c", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"528716ca67888ffb73955c1e2da35cc0964fbc88", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Contact\Index.cshtml"
   ViewData["Title"] = "Contact"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Contact Start -->
<div class=""map-area"">
    <!-- google-map-area start -->
    <div class=""google-map-area"">
        <!--  Map Section -->
        <div id=""contacts"" class=""map-area"">
            <div id=""googleMap"" style=""width:100%;height:440px;"">
                <div class=""mapouter""><div class=""gmap_canvas"">
                    <iframe width=""100%"" height=""440"" id=""gmap_canvas"" src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d48622.4486188755!2d49.911246550728244!3d40.388841536312846!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x40306357e5b177ef%3A0x7040e87a3661bcda!2sHazi%20Aslanov!5e0!3m2!1sen!2s!4v1609702752247!5m2!1sen!2s"" frameborder=""0"" scrolling=""no"" marginheight=""0"" marginwidth=""0""></iframe><a href=""https://fmovies2.org"">the fmovies</a></div>
                <style>
                    .mapouter {
                        position: relative;
                        text-align: right;
                        height: 440px;
                        width: 100%;
                  ");
            WriteLiteral(@"  }

                    .gmap_canvas {
                        overflow: hidden;
                        background: none !important;
                        height: 440px;
                        width: 100%;
                    }
                </style>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""contact-area pt-150 pb-140"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-5 col-sm-5 col-xs-12"">
                <div class=""contact-contents text-center"">

                    <div class=""single-contact mb-65"">
                        <div class=""contact-icon"">
                            <img src=""img/contact/contact1.png"" alt=""contact"">
                        </div>
                        <div class=""contact-add"">
                            <h3>address</h3>
                            <p>135, First Lane, City Street</p>
                            <p>New Yourk City, USA</p>
                        </div>
                    <");
            WriteLiteral(@"/div>
                    <div class=""single-contact mb-65"">
                        <div class=""contact-icon"">
                            <img src=""img/contact/contact2.png"" alt=""contact"">
                        </div>
                        <div class=""contact-add"">
                            <h3>address</h3>
                            <p>135, First Lane, City Street</p>
                            <p>New Yourk City, USA</p>
                        </div>
                    </div>
                    <div class=""single-contact"">
                        <div class=""contact-icon"">
                            <img src=""img/contact/contact3.png"" alt=""contact"">
                        </div>
                        <div class=""contact-add"">
                            <h3>address</h3>
                            <p>135, First Lane, City Street</p>
                            <p>New Yourk City, USA</p>
                        </div>
                    </div>
                </div>
            </div>
      ");
            WriteLiteral("      <div class=\"col-md-7 col-sm-7 col-xs-12\">\n                ");
#nullable restore
#line 71 "C:\Users\musta\Desktop\EduHome\EduHomeASPNET\Views\Contact\Index.cshtml"
           Write(await Component.InvokeAsync("Reply"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \n            </div>\n        </div>\n    </div>\n</div>\n<!-- Contact End -->\n");
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
