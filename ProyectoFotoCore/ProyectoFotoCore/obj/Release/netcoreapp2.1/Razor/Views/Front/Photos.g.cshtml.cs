#pragma checksum "G:\Proyectos\ProyectoFotoAPIAzure\ProyectoFotoCore\ProyectoFotoCore\Views\Front\Photos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06a9613882032a4fa0e96bcccac5fccfd323604b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Front_Photos), @"mvc.1.0.view", @"/Views/Front/Photos.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Front/Photos.cshtml", typeof(AspNetCore.Views_Front_Photos))]
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
#line 1 "G:\Proyectos\ProyectoFotoAPIAzure\ProyectoFotoCore\ProyectoFotoCore\Views\Front\Photos.cshtml"
using ProyectoFotoCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06a9613882032a4fa0e96bcccac5fccfd323604b", @"/Views/Front/Photos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb6de92ebe6cb4bf092acae0a3d4ee46870dfebb", @"/Views/_ViewImports.cshtml")]
    public class Views_Front_Photos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PHOTO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/styleGridImagesFront.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "G:\Proyectos\ProyectoFotoAPIAzure\ProyectoFotoCore\ProyectoFotoCore\Views\Front\Photos.cshtml"
  
    ViewData["Title"] = "Photos";
    Layout = "~/Views/Shared/_LayoutFront.cshtml";

#line default
#line hidden
            BeginContext(146, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("styles", async() => {
                BeginContext(164, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(170, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "81c70c97299f427888516cbb35886312", async() => {
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
                BeginContext(233, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(238, 32, true);
            WriteLiteral("<section id=\"photos\" class=\"\">\r\n");
            EndContext();
#line 12 "G:\Proyectos\ProyectoFotoAPIAzure\ProyectoFotoCore\ProyectoFotoCore\Views\Front\Photos.cshtml"
     if (Model.Count() > 0)
    {
        foreach (PHOTO p in Model)
        {

#line default
#line hidden
            BeginContext(353, 16, true);
            WriteLiteral("            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 369, "\"", 386, 1);
#line 16 "G:\Proyectos\ProyectoFotoAPIAzure\ProyectoFotoCore\ProyectoFotoCore\Views\Front\Photos.cshtml"
WriteAttributeValue("", 375, p.UriAzure, 375, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(387, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 17 "G:\Proyectos\ProyectoFotoAPIAzure\ProyectoFotoCore\ProyectoFotoCore\Views\Front\Photos.cshtml"
        }
    }

#line default
#line hidden
            BeginContext(410, 14, true);
            WriteLiteral("</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PHOTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
