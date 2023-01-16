#pragma checksum "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Actividad\ListaActividadUsuarioCliente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7382b83aa0277e63d4a496960e39dbde652d5113"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Actividad_ListaActividadUsuarioCliente), @"mvc.1.0.view", @"/Views/Actividad/ListaActividadUsuarioCliente.cshtml")]
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
#line 1 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Actividad\ListaActividadUsuarioCliente.cshtml"
using Dominio;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7382b83aa0277e63d4a496960e39dbde652d5113", @"/Views/Actividad/ListaActividadUsuarioCliente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27b20056d631a5ab68766dd092e1b65a7f8f3a8d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Actividad_ListaActividadUsuarioCliente : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Actividad\ListaActividadUsuarioCliente.cshtml"
  
    ViewData["Title"] = "Lista de Actividades";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1>Listado de actividades</h1>\r\n");
#nullable restore
#line 8 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Actividad\ListaActividadUsuarioCliente.cshtml"
 if (ViewBag.Mensaje != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\">\r\n        ");
#nullable restore
#line 11 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Actividad\ListaActividadUsuarioCliente.cshtml"
   Write(ViewBag.Mensaje);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 13 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Actividad\ListaActividadUsuarioCliente.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table table-striped"">
    <thead>
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Nombre</th>
            <th scope=""col"">Fecha</th>
            <th scope=""col"">Edad mínima</th>
            <th scope=""col"">Me gusta</th>
            <th scope=""col"">Categoría</th>
            <th scope=""col"">Lugar</th>
            <th scope=""col"">Precio</th>

        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 30 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Actividad\ListaActividadUsuarioCliente.cshtml"
         foreach (Actividad item in @ViewBag.Actividades)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 33 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Actividad\ListaActividadUsuarioCliente.cshtml"
                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 34 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Actividad\ListaActividadUsuarioCliente.cshtml"
               Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Actividad\ListaActividadUsuarioCliente.cshtml"
               Write(item.Fecha.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Actividad\ListaActividadUsuarioCliente.cshtml"
               Write(item.EdadMinima);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 37 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Actividad\ListaActividadUsuarioCliente.cshtml"
               Write(item.MeGusta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 38 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Actividad\ListaActividadUsuarioCliente.cshtml"
               Write(item.NombreCategoria());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 39 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Actividad\ListaActividadUsuarioCliente.cshtml"
               Write(item.Lugar.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>$");
#nullable restore
#line 40 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Actividad\ListaActividadUsuarioCliente.cshtml"
                Write(item.TotalActividad());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 1159, "\"", 1190, 2);
            WriteAttributeValue("", 1166, "/Compra/Comprar/", 1166, 16, true);
#nullable restore
#line 41 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Actividad\ListaActividadUsuarioCliente.cshtml"
WriteAttributeValue("", 1182, item.Id, 1182, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Comprar</a></td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 1232, "\"", 1269, 2);
            WriteAttributeValue("", 1239, "/Actividad/DarMeGusta/", 1239, 22, true);
#nullable restore
#line 42 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Actividad\ListaActividadUsuarioCliente.cshtml"
WriteAttributeValue("", 1261, item.Id, 1261, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Ver</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 44 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Actividad\ListaActividadUsuarioCliente.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n\r\n");
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
