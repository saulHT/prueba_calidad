#pragma checksum "D:\Visual_Proyecto\Nueva carpeta\core_practica\core_practica\Views\Home\Hola.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0aef2e535f5bd936a3d288e9386be277f1e1006"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Hola), @"mvc.1.0.view", @"/Views/Home/Hola.cshtml")]
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
#line 1 "D:\Visual_Proyecto\Nueva carpeta\core_practica\core_practica\Views\_ViewImports.cshtml"
using core_practica;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Visual_Proyecto\Nueva carpeta\core_practica\core_practica\Views\_ViewImports.cshtml"
using core_practica.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0aef2e535f5bd936a3d288e9386be277f1e1006", @"/Views/Home/Hola.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50f03165dc8a9c35a0d295e5a4c1d65b589ede16", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Hola : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Visual_Proyecto\Nueva carpeta\core_practica\core_practica\Views\Home\Hola.cshtml"
  
    ViewData["Title"] = "Hola";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Hola mundo</h1>\r\n<div>\r\n\r\n    <h1>");
#nullable restore
#line 12 "D:\Visual_Proyecto\Nueva carpeta\core_practica\core_practica\Views\Home\Hola.cshtml"
   Write(ViewBag.Numero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <h2>");
#nullable restore
#line 13 "D:\Visual_Proyecto\Nueva carpeta\core_practica\core_practica\Views\Home\Hola.cshtml"
   Write(ViewBag.Persona.id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 13 "D:\Visual_Proyecto\Nueva carpeta\core_practica\core_practica\Views\Home\Hola.cshtml"
                       Write(ViewBag.Persona.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n    <h3>");
#nullable restore
#line 15 "D:\Visual_Proyecto\Nueva carpeta\core_practica\core_practica\Views\Home\Hola.cshtml"
   Write(Model.id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 15 "D:\Visual_Proyecto\Nueva carpeta\core_practica\core_practica\Views\Home\Hola.cshtml"
             Write(Model.apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n</div>  ");
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
