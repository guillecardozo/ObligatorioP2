#pragma checksum "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Actividad\MostrarActividadesPorLugar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e434241e2ed3fe506f10f137530e48bd7b65baa8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Actividad_MostrarActividadesPorLugar), @"mvc.1.0.view", @"/Views/Actividad/MostrarActividadesPorLugar.cshtml")]
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
#line 1 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Actividad\MostrarActividadesPorLugar.cshtml"
using Dominio;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e434241e2ed3fe506f10f137530e48bd7b65baa8", @"/Views/Actividad/MostrarActividadesPorLugar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27b20056d631a5ab68766dd092e1b65a7f8f3a8d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Actividad_MostrarActividadesPorLugar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Actividad\MostrarActividadesPorLugar.cshtml"
  
    ViewData["Title"] = "Mostrar Actividades por Lugar";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Listado de actividades por Lugar</h1>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Actividad\MostrarActividadesPorLugar.cshtml"
  
    List<Actividad> actividadesLugar = ViewBag.ActividadesLugar;
    if (actividadesLugar.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table table-striped"">
            <thead>
                <tr>
                    <th scope=""col"">Nombre</th>
                    <th scope=""col"">Fecha</th>
                    <th scope=""col"">Edad m??nima</th>
                    <th scope=""col"">Cantidad de Me Gusta</th>
                    <th scope=""col"">Categor??a</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 23 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Actividad\MostrarActividadesPorLugar.cshtml"
                 foreach (Actividad item in actividadesLugar)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 26 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Actividad\MostrarActividadesPorLugar.cshtml"
                       Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 27 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Actividad\MostrarActividadesPorLugar.cshtml"
                       Write(item.Fecha.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 28 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Actividad\MostrarActividadesPorLugar.cshtml"
                       Write(item.EdadMinima);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 29 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Actividad\MostrarActividadesPorLugar.cshtml"
                       Write(item.MeGusta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 30 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Actividad\MostrarActividadesPorLugar.cshtml"
                       Write(item.NombreCategoria());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 32 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Actividad\MostrarActividadesPorLugar.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 35 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Actividad\MostrarActividadesPorLugar.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
