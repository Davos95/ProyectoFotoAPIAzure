#pragma checksum "G:\Proyectos\ProyectoFotoAPIAzure\ProyectoFotoCore\ProyectoFotoCore\Views\Front\Comision.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd24c0fae5a285d04b83a443393b246b95c33156"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Front_Comision), @"mvc.1.0.view", @"/Views/Front/Comision.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Front/Comision.cshtml", typeof(AspNetCore.Views_Front_Comision))]
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
#line 1 "G:\Proyectos\ProyectoFotoAPIAzure\ProyectoFotoCore\ProyectoFotoCore\Views\Front\Comision.cshtml"
using ProyectoFotoCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd24c0fae5a285d04b83a443393b246b95c33156", @"/Views/Front/Comision.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb6de92ebe6cb4bf092acae0a3d4ee46870dfebb", @"/Views/_ViewImports.cshtml")]
    public class Views_Front_Comision : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<COMISION>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "G:\Proyectos\ProyectoFotoAPIAzure\ProyectoFotoCore\ProyectoFotoCore\Views\Front\Comision.cshtml"
  
    ViewData["Title"] = "Comision";
    Layout = "~/Views/Shared/_LayoutFront.cshtml";

#line default
#line hidden
            DefineSection("events", async() => {
                BeginContext(170, 103, true);
                WriteLiteral("\r\n<script>\r\n    $(document).ready(function(){\r\n        $(\'.parallax\').parallax();\r\n    });\r\n</script>\r\n");
                EndContext();
            }
            );
#line 15 "G:\Proyectos\ProyectoFotoAPIAzure\ProyectoFotoCore\ProyectoFotoCore\Views\Front\Comision.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
            BeginContext(304, 23, true);
            WriteLiteral("    <div class=\"row\">\r\n");
            EndContext();
#line 18 "G:\Proyectos\ProyectoFotoAPIAzure\ProyectoFotoCore\ProyectoFotoCore\Views\Front\Comision.cshtml"
         foreach (COMISION c in Model)
        {

#line default
#line hidden
            BeginContext(378, 110, true);
            WriteLiteral("            <div class=\"parallax-container\">\r\n                <div class=\"parallax\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 488, "\"", 505, 1);
#line 22 "G:\Proyectos\ProyectoFotoAPIAzure\ProyectoFotoCore\ProyectoFotoCore\Views\Front\Comision.cshtml"
WriteAttributeValue("", 494, c.UriAzure, 494, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(506, 172, true);
            WriteLiteral(">\r\n                </div>\r\n            </div>\r\n            <div class=\"section white\">\r\n                <div class=\"row container\">\r\n                    <h2 class=\"header\">");
            EndContext();
            BeginContext(679, 6, false);
#line 27 "G:\Proyectos\ProyectoFotoAPIAzure\ProyectoFotoCore\ProyectoFotoCore\Views\Front\Comision.cshtml"
                                  Write(c.Name);

#line default
#line hidden
            EndContext();
            BeginContext(685, 121, true);
            WriteLiteral("</h2>\r\n                    <div class=\"divider\"></div>\r\n                    <p class=\"grey-text text-darken-3 lighten-3\">");
            EndContext();
            BeginContext(807, 13, false);
#line 29 "G:\Proyectos\ProyectoFotoAPIAzure\ProyectoFotoCore\ProyectoFotoCore\Views\Front\Comision.cshtml"
                                                            Write(c.Description);

#line default
#line hidden
            EndContext();
            BeginContext(820, 82, true);
            WriteLiteral("</p>\r\n                    <p class=\"grey-text text-darken-3 lighten-3\"><b>Precio: ");
            EndContext();
            BeginContext(903, 7, false);
#line 30 "G:\Proyectos\ProyectoFotoAPIAzure\ProyectoFotoCore\ProyectoFotoCore\Views\Front\Comision.cshtml"
                                                                       Write(c.Price);

#line default
#line hidden
            EndContext();
            BeginContext(910, 56, true);
            WriteLiteral(" €</b></p>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 33 "G:\Proyectos\ProyectoFotoAPIAzure\ProyectoFotoCore\ProyectoFotoCore\Views\Front\Comision.cshtml"
        }

#line default
#line hidden
            BeginContext(977, 12, true);
            WriteLiteral("    </div>\r\n");
            EndContext();
#line 35 "G:\Proyectos\ProyectoFotoAPIAzure\ProyectoFotoCore\ProyectoFotoCore\Views\Front\Comision.cshtml"
}

#line default
#line hidden
            BeginContext(992, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<COMISION>> Html { get; private set; }
    }
}
#pragma warning restore 1591
