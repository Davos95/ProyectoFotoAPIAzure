#pragma checksum "G:\Proyectos\ProyectoFotoAPIAzure\ProyectoFotoCore\ProyectoFotoCore\Views\PartnerWork\Partners.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d92d244aaad4e8df810123abfb979a5fd50cc513"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PartnerWork_Partners), @"mvc.1.0.view", @"/Views/PartnerWork/Partners.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PartnerWork/Partners.cshtml", typeof(AspNetCore.Views_PartnerWork_Partners))]
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
#line 1 "G:\Proyectos\ProyectoFotoAPIAzure\ProyectoFotoCore\ProyectoFotoCore\Views\PartnerWork\Partners.cshtml"
using ProyectoFotoCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d92d244aaad4e8df810123abfb979a5fd50cc513", @"/Views/PartnerWork/Partners.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb6de92ebe6cb4bf092acae0a3d4ee46870dfebb", @"/Views/_ViewImports.cshtml")]
    public class Views_PartnerWork_Partners : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WORKER>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/stylePartners.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(52, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 5 "G:\Proyectos\ProyectoFotoAPIAzure\ProyectoFotoCore\ProyectoFotoCore\Views\PartnerWork\Partners.cshtml"
  
    ViewBag.Title = "Partners";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(136, 1, true);
            WriteLiteral("\n");
            EndContext();
            DefineSection("styles", async() => {
                BeginContext(154, 1, true);
                WriteLiteral("\n");
                EndContext();
                BeginContext(155, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "976c4c77fd6c4b2189f8b45e36001c43", async() => {
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
                BeginContext(211, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            BeginContext(214, 2, true);
            WriteLiteral("\n\n");
            EndContext();
            DefineSection("events", async() => {
                BeginContext(233, 1219, true);
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $(""tr"").click(function () {
                if ($(this).css(""background-color"") == ""rgb(224, 224, 224)"") {
                    $(""tr"").css(""background-color"", ""white"");
                    $(""#name"").val("""");
                    $(""#contact"").val("""");
                    $(""#urlContact"").val("""");
                    $(""#id"").val("""");
                } else {
                    $(""tr"").css(""background-color"", ""white"");
                    $(this).css(""background-color"", ""rgb(224, 224, 224)"");
                    $(""#contact"").val($(this).find(""td"")[1].textContent).focus();
                    $(""#urlContact"").val($(this).find(""td"")[2].textContent).focus();
                    $(""#name"").val($(this).find(""td"")[0].textContent).focus();
                    $(""#id"").val($(this).find(""td"")[3].textContent);
                }
            });

            var width = $(""table"").width() / 3;
            $(""thead th, tbody td"").css(""width"", width);

    ");
                WriteLiteral("        $(window).resize(function () {\n                var width = $(\"table\").width() / 3;\n                $(\"thead th, tbody td\").css(\"width\", width);\n            });\n\n        });\n    </script>\n");
                EndContext();
            }
            );
            BeginContext(1454, 248, true);
            WriteLiteral("\n<div class=\"row\" style=\"padding: 1rem 1.2rem;\">\n    <div class=\"col s12 m4 l4 xl3\">\n        <div class=\"card\">\n            <div class=\"card-title center-align title\"><i class=\"material-icons iconTitle\">person_add</i>Participante</div>\n            ");
            EndContext();
            BeginContext(1702, 1277, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65449010ac904233adb41d76d5612c30", async() => {
                BeginContext(1722, 1250, true);
                WriteLiteral(@"
                <div class=""card-content card-content-padding"">
                    <div class=""input-field"">
                        <input type=""text"" name=""name"" id=""name"" />
                        <label for=""name""><i class=""material-icons iconInput"">person</i> Nombre</label>
                    </div>
                    <div class=""input-field"">
                        <input type=""text"" name=""contact"" id=""contact"" />
                        <label for=""contact""><i class=""material-icons iconInput"">contact_mail</i>Contacto</label>
                    </div>
                    <div class=""input-field"">
                        <input type=""text"" name=""urlContact"" id=""urlContact"" />
                        <label for=""urlContact""><i class=""material-icons iconInput"">attachment</i>Url Contacto</label>
                    </div>
                    <input type=""number"" name=""id"" id=""id"" hidden />
                    <button type=""submit"" class=""btn green waves-effect waves-darken"" name=""option"" value=""1"">Añ");
                WriteLiteral("adir</button>\n                    <div class=\"divider\"></div>\n                    <button type=\"submit\" class=\"btn green waves-effect waves-darken\" name=\"option\" value=\"2\">Modificar</button>\n                </div>\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2979, 560, true);
            WriteLiteral(@"
        </div>
    </div>

    <div class=""col s12 m7 l7 xl7 offset-m1 offset-l1 offset-xl1"">
        <div class=""card"">
            <div class=""card-content"">
                <table class=""responsive-table tbpar"">
                    <thead class=""tbpar"">
                        <tr>
                            <th>Nombre</th>
                            <th>Contacto</th>
                            <th>Enlace</th>
                            <th></th>
                        </tr>
                    </thead>
                    <tbody class=""tbpar"">
");
            EndContext();
#line 87 "G:\Proyectos\ProyectoFotoAPIAzure\ProyectoFotoCore\ProyectoFotoCore\Views\PartnerWork\Partners.cshtml"
                         if (Model != null)
                        {
                            foreach (WORKER w in Model)
                            {

#line default
#line hidden
            BeginContext(3695, 77, true);
            WriteLiteral("                                <tr>\n                                    <td>");
            EndContext();
            BeginContext(3773, 6, false);
#line 92 "G:\Proyectos\ProyectoFotoAPIAzure\ProyectoFotoCore\ProyectoFotoCore\Views\PartnerWork\Partners.cshtml"
                                   Write(w.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3779, 46, true);
            WriteLiteral("</td>\n                                    <td>");
            EndContext();
            BeginContext(3826, 9, false);
#line 93 "G:\Proyectos\ProyectoFotoAPIAzure\ProyectoFotoCore\ProyectoFotoCore\Views\PartnerWork\Partners.cshtml"
                                   Write(w.Contact);

#line default
#line hidden
            EndContext();
            BeginContext(3835, 71, true);
            WriteLiteral("</td>\n                                    <td><a target=\"_blank\" rel=\"\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3906, "\"", 3926, 1);
#line 94 "G:\Proyectos\ProyectoFotoAPIAzure\ProyectoFotoCore\ProyectoFotoCore\Views\PartnerWork\Partners.cshtml"
WriteAttributeValue("", 3913, w.UrlContact, 3913, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3927, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3929, 12, false);
#line 94 "G:\Proyectos\ProyectoFotoAPIAzure\ProyectoFotoCore\ProyectoFotoCore\Views\PartnerWork\Partners.cshtml"
                                                                                  Write(w.UrlContact);

#line default
#line hidden
            EndContext();
            BeginContext(3941, 57, true);
            WriteLiteral("</a></td>\n                                    <td hidden>");
            EndContext();
            BeginContext(3999, 4, false);
#line 95 "G:\Proyectos\ProyectoFotoAPIAzure\ProyectoFotoCore\ProyectoFotoCore\Views\PartnerWork\Partners.cshtml"
                                          Write(w.Id);

#line default
#line hidden
            EndContext();
            BeginContext(4003, 48, true);
            WriteLiteral("</td>\n                                    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4051, "\"", 4117, 1);
#line 96 "G:\Proyectos\ProyectoFotoAPIAzure\ProyectoFotoCore\ProyectoFotoCore\Views\PartnerWork\Partners.cshtml"
WriteAttributeValue("", 4058, Url.Action("DeletePartner","PartnerWork",new { id = w.Id}), 4058, 59, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4118, 119, true);
            WriteLiteral("><i class=\"material-icons\" style=\"color:red; float:right\">backspace</i></a></td>\n                                </tr>\n");
            EndContext();
#line 98 "G:\Proyectos\ProyectoFotoAPIAzure\ProyectoFotoCore\ProyectoFotoCore\Views\PartnerWork\Partners.cshtml"
                            }
                        }

#line default
#line hidden
            BeginContext(4293, 107, true);
            WriteLiteral("                    </tbody>\n                </table>\n            </div>\n        </div>\n    </div>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WORKER>> Html { get; private set; }
    }
}
#pragma warning restore 1591
