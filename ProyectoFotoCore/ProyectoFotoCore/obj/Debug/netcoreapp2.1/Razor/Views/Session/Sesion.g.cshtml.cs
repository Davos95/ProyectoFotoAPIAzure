#pragma checksum "G:\Proyectos\ProyectoFotoAPIAzure\ProyectoFotoCore\ProyectoFotoCore\Views\Session\Sesion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a0034675b82b9b08ede58e934f55a1aa6e605be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Session_Sesion), @"mvc.1.0.view", @"/Views/Session/Sesion.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Session/Sesion.cshtml", typeof(AspNetCore.Views_Session_Sesion))]
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
#line 1 "G:\Proyectos\ProyectoFotoAPIAzure\ProyectoFotoCore\ProyectoFotoCore\Views\_ViewImports.cshtml"
using ProyectoFotoCore;

#line default
#line hidden
#line 1 "G:\Proyectos\ProyectoFotoAPIAzure\ProyectoFotoCore\ProyectoFotoCore\Views\Session\Sesion.cshtml"
using ProyectoFotoCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a0034675b82b9b08ede58e934f55a1aa6e605be", @"/Views/Session/Sesion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb6de92ebe6cb4bf092acae0a3d4ee46870dfebb", @"/Views/_ViewImports.cshtml")]
    public class Views_Session_Sesion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SESSION_COMPLEX>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("activator img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/default/default.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(60, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "G:\Proyectos\ProyectoFotoAPIAzure\ProyectoFotoCore\ProyectoFotoCore\Views\Session\Sesion.cshtml"
  
    ViewBag.Title = "Sesion";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            DefineSection("styles", async() => {
                BeginContext(159, 172, true);
                WriteLiteral("\n    <style>\n        .noPadding {\n            padding: 0px !important;\n        }\n        .img {\n            width: 240px;\n            height: 240px;\n        }\n    </style>\n");
                EndContext();
            }
            );
            DefineSection("events", async() => {
                BeginContext(349, 107, true);
                WriteLiteral("\n    <script>\n        $(document).ready(function () {\n            M.AutoInit();\n        });\n    </script>\n\n");
                EndContext();
            }
            );
            BeginContext(458, 155, true);
            WriteLiteral("\n<div class=\"row\">\n    <div class=\"col s12 m10 l10 xl10 offset-m1 offset-l1 offset-xl1\">\n        <div class=\"card\">\n            <div class=\"card-content\">\n");
            EndContext();
#line 32 "G:\Proyectos\ProyectoFotoAPIAzure\ProyectoFotoCore\ProyectoFotoCore\Views\Session\Sesion.cshtml"
                 if (Model != null)
                {

#line default
#line hidden
            BeginContext(667, 38, true);
            WriteLiteral("                    <div class=\"row\">\n");
            EndContext();
#line 35 "G:\Proyectos\ProyectoFotoAPIAzure\ProyectoFotoCore\ProyectoFotoCore\Views\Session\Sesion.cshtml"
                         foreach (SESSION_COMPLEX s in Model)
                        {

#line default
#line hidden
            BeginContext(793, 182, true);
            WriteLiteral("                            <div class=\"col s12 m8 l6 xl4\">\n                                <div class=\"card\">\n                                    <div class=\"card-image activator\">\n");
            EndContext();
#line 40 "G:\Proyectos\ProyectoFotoAPIAzure\ProyectoFotoCore\ProyectoFotoCore\Views\Session\Sesion.cshtml"
                                         if (s.IdPhoto == 0)
                                        {

#line default
#line hidden
            BeginContext(1078, 44, true);
            WriteLiteral("                                            ");
            EndContext();
            BeginContext(1122, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1647ebe0064a4729b78df2a8957724d9", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1184, 99, true);
            WriteLiteral("\n                                            <div class=\"card-title activator\" style=\"color:black\">");
            EndContext();
            BeginContext(1284, 6, false);
#line 43 "G:\Proyectos\ProyectoFotoAPIAzure\ProyectoFotoCore\ProyectoFotoCore\Views\Session\Sesion.cshtml"
                                                                                             Write(s.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1290, 7, true);
            WriteLiteral("</div>\n");
            EndContext();
#line 44 "G:\Proyectos\ProyectoFotoAPIAzure\ProyectoFotoCore\ProyectoFotoCore\Views\Session\Sesion.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
            BeginContext(1426, 70, true);
            WriteLiteral("                                            <img class=\"activator img\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1496, "\"", 1513, 1);
#line 47 "G:\Proyectos\ProyectoFotoAPIAzure\ProyectoFotoCore\ProyectoFotoCore\Views\Session\Sesion.cshtml"
WriteAttributeValue("", 1502, s.UriAzure, 1502, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1514, 107, true);
            WriteLiteral(" style=\"object-fit:cover;\">\n                                            <div class=\"card-title activator\" >");
            EndContext();
            BeginContext(1622, 6, false);
#line 48 "G:\Proyectos\ProyectoFotoAPIAzure\ProyectoFotoCore\ProyectoFotoCore\Views\Session\Sesion.cshtml"
                                                                          Write(s.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1628, 7, true);
            WriteLiteral("</div>\n");
            EndContext();
#line 49 "G:\Proyectos\ProyectoFotoAPIAzure\ProyectoFotoCore\ProyectoFotoCore\Views\Session\Sesion.cshtml"
                                        }

#line default
#line hidden
            BeginContext(1677, 260, true);
            WriteLiteral(@"
                                    </div>
                                    <div class=""card-content"">
                                        
                                        <div class=""card-action"">
                                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1937, "\"", 2015, 1);
#line 55 "G:\Proyectos\ProyectoFotoAPIAzure\ProyectoFotoCore\ProyectoFotoCore\Views\Session\Sesion.cshtml"
WriteAttributeValue("", 1944, Url.Action("DeleteSesion","Session",new { id = s.Id, name = s.Name  }), 1944, 71, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2016, 127, true);
            WriteLiteral(" style=\"float: right\"><i class=\"material-icons\" style=\"color:red\">delete</i></a>\n                                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2143, "\"", 2203, 1);
#line 56 "G:\Proyectos\ProyectoFotoAPIAzure\ProyectoFotoCore\ProyectoFotoCore\Views\Session\Sesion.cshtml"
WriteAttributeValue("", 2150, Url.Action("EditSesion","Session",new { id = s.Id }), 2150, 53, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2204, 129, true);
            WriteLiteral(" style=\"float: right\"><i class=\"material-icons\" style=\"color: black;\">edit</i></a>\n                                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2333, "\"", 2401, 1);
#line 57 "G:\Proyectos\ProyectoFotoAPIAzure\ProyectoFotoCore\ProyectoFotoCore\Views\Session\Sesion.cshtml"
WriteAttributeValue("", 2340, Url.Action("ManagePhotos","Session",new { idSesion = s.Id }), 2340, 61, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2402, 411, true);
            WriteLiteral(@" style=""float: right""><i class=""material-icons"" style=""color: black;"">photo_library</i></a>
                                        </div>
                                    </div>
                                    <div class=""card-reveal"">
                                        <span class=""card-title noPadding""><i class=""material-icons right"">close</i></span>
                                        <p>");
            EndContext();
            BeginContext(2814, 13, false);
#line 62 "G:\Proyectos\ProyectoFotoAPIAzure\ProyectoFotoCore\ProyectoFotoCore\Views\Session\Sesion.cshtml"
                                      Write(s.Description);

#line default
#line hidden
            EndContext();
            BeginContext(2827, 122, true);
            WriteLiteral("</p>\n                                    </div>\n                                </div>\n                            </div>\n");
            EndContext();
#line 66 "G:\Proyectos\ProyectoFotoAPIAzure\ProyectoFotoCore\ProyectoFotoCore\Views\Session\Sesion.cshtml"
                        }

#line default
#line hidden
            BeginContext(2975, 27, true);
            WriteLiteral("                    </div>\n");
            EndContext();
#line 68 "G:\Proyectos\ProyectoFotoAPIAzure\ProyectoFotoCore\ProyectoFotoCore\Views\Session\Sesion.cshtml"
                }

#line default
#line hidden
            BeginContext(3020, 117, true);
            WriteLiteral("            </div>\n\n        </div>\n    </div>\n</div>\n\n<div class=\"fixed-action-btn\" style=\"margin-bottom:5em\">\n    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3137, "\"", 3181, 1);
#line 76 "G:\Proyectos\ProyectoFotoAPIAzure\ProyectoFotoCore\ProyectoFotoCore\Views\Session\Sesion.cshtml"
WriteAttributeValue("", 3144, Url.Action("CreateSesion","Session"), 3144, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3182, 175, true);
            WriteLiteral(" class=\"btn-floating btn-large green\">\n        <i class=\"large material-icons\">add_circle</i>\n    </a>\n</div>\n\n<div class=\"fixed-action-btn\" style=\"margin-bottom:10em\">\n    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3357, "\"", 3403, 1);
#line 82 "G:\Proyectos\ProyectoFotoAPIAzure\ProyectoFotoCore\ProyectoFotoCore\Views\Session\Sesion.cshtml"
WriteAttributeValue("", 3364, Url.Action("FavoritePhotos","Session"), 3364, 39, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3404, 107, true);
            WriteLiteral(" class=\"btn-floating btn-large red\">\n        <i class=\"large material-icons\">favorite</i>\n    </a>\n</div>\n\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SESSION_COMPLEX>> Html { get; private set; }
    }
}
#pragma warning restore 1591
