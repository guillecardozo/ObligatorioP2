#pragma checksum "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Compra\DatosDeCompras.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fba07bd9b4bbf3c74342b6ccb1266ca962dfc283"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Compra_DatosDeCompras), @"mvc.1.0.view", @"/Views/Compra/DatosDeCompras.cshtml")]
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
#line 1 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\_ViewImports.cshtml"
using Obligatorio02;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\_ViewImports.cshtml"
using Obligatorio02.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Compra\DatosDeCompras.cshtml"
using Dominio;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fba07bd9b4bbf3c74342b6ccb1266ca962dfc283", @"/Views/Compra/DatosDeCompras.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27b20056d631a5ab68766dd092e1b65a7f8f3a8d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Compra_DatosDeCompras : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Compra\DatosDeCompras.cshtml"
  
    ViewData["Title"] = "Datos de compras";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Datos de sus compras</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Compra\DatosDeCompras.cshtml"
 if (ViewBag.Mensaje != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\">\r\n        ");
#nullable restore
#line 12 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Compra\DatosDeCompras.cshtml"
   Write(ViewBag.Mensaje);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 14 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Compra\DatosDeCompras.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table table-striped"">
    <thead>
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Cantidad de entradas</th>
            <th scope=""col"">Fecha y hora</th>
            <th scope=""col"">Estado</th>
            <th scope=""col"">Actividad</th>
            <th scope=""col"">Total de la compra</th>

        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 29 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Compra\DatosDeCompras.cshtml"
         foreach (Compra item in ViewBag.Compras)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 32 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Compra\DatosDeCompras.cshtml"
                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Compra\DatosDeCompras.cshtml"
               Write(item.CantidadEntradas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Compra\DatosDeCompras.cshtml"
               Write(item.FechaYHora);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Compra\DatosDeCompras.cshtml"
               Write(item.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Compra\DatosDeCompras.cshtml"
               Write(item.NombreActividad());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>$");
#nullable restore
#line 37 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Compra\DatosDeCompras.cshtml"
                Write(item.TotalDeCompra());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 38 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Compra\DatosDeCompras.cshtml"
                 if (item.Estado == "Activa")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1068, "\"", 1109, 2);
            WriteAttributeValue("", 1075, "/Compra/CancelarCompra?id=", 1075, 26, true);
#nullable restore
#line 40 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Compra\DatosDeCompras.cshtml"
WriteAttributeValue("", 1101, item.Id, 1101, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Cancelar</a></td>\r\n");
#nullable restore
#line 41 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Compra\DatosDeCompras.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 43 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Compra\DatosDeCompras.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591