#pragma checksum "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Usuario\ListaClientes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3aa1b196c01236f72cda1a93d88489716a2aed3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_ListaClientes), @"mvc.1.0.view", @"/Views/Usuario/ListaClientes.cshtml")]
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
#line 1 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Usuario\ListaClientes.cshtml"
using Dominio;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3aa1b196c01236f72cda1a93d88489716a2aed3", @"/Views/Usuario/ListaClientes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27b20056d631a5ab68766dd092e1b65a7f8f3a8d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Usuario_ListaClientes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Usuario\ListaClientes.cshtml"
  
    ViewData["Title"] = "Lista de Clientes";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Listado de Clientes</h1>


<table class=""table table-striped"">
    <thead>
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Nombre</th>
            <th scope=""col"">Apellido</th>
            <th scope=""col"">Fecha de Nacimiento</th>
            <th scope=""col"">Nombre de usuario</th>
            <th scope=""col"">E-mail</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 22 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Usuario\ListaClientes.cshtml"
         foreach (Usuario item in ViewBag.Usuarios)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 25 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Usuario\ListaClientes.cshtml"
                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Usuario\ListaClientes.cshtml"
               Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Usuario\ListaClientes.cshtml"
               Write(item.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Usuario\ListaClientes.cshtml"
               Write(item.FechaNacimiento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Usuario\ListaClientes.cshtml"
               Write(item.NombreUsuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Usuario\ListaClientes.cshtml"
               Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 32 "C:\Users\Usuario\OneDrive - Facultad de Ingenieria - Universidad ORT Uruguay\ATI\2 Semestre\Programacion 2\Obligatorio\Obligatorio02\Obligatorio02\Views\Usuario\ListaClientes.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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