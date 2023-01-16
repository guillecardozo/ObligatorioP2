using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;
using Microsoft.AspNetCore.Http;

namespace Obligatorio02.Controllers
{
    public class CompraController : Controller
    {
        Sistema unS = Sistema.Instancia;

        public IActionResult Comprar(int id)
        {
            if (HttpContext.Session.GetString("rol") == null)
            {
                return Redirect("/Usuario/Login");
            }
            Actividad unaA = unS.ObtenerActividad(id);
            if (unaA == null)
            {
                return Redirect("ListaActividadUsuarioCliente");//Me lleva al metodo en el controlador de actividad
            }
            ViewBag.Id = id;
            ViewBag.Nombre = unaA.Nombre;
            return View(new Compra());
        }

        [HttpPost]
        public IActionResult Comprar(Compra compra, int id)
        {
            Usuario unU = unS.ObtenerUsuario(HttpContext.Session.GetString("nombreUsuario"));
            Actividad unaA = unS.ObtenerActividad(id);
            compra.Actividad = unaA;
            compra.Usuario = unU;
            if (unS.AgregarCompra(compra) && compra.CantidadEntradas > 0)
            {
                return Redirect("/Actividad/ListaActividadUsuarioCliente?Mensaje=Compra exitosa");
            }
            ViewBag.Mensaje = "No se pudo realizar la compra";
            ViewBag.Id = id;
            return View(compra);
        }

        public IActionResult DatosDeCompras(string mensaje)//View de todas las compras que realizo y un boton para cancelar
        {
            if (HttpContext.Session.GetString("rol") == null)
            {
                return Redirect("/Usuario/Login");
            }
            if (HttpContext.Session.GetString("rol") != "Cliente")
            {
                return RedirectToAction("DatosDeCompras");
            }
            ViewBag.Compras = unS.ComprasXUsuario(HttpContext.Session.GetString("nombreUsuario"));
            ViewBag.Mensaje = mensaje;
            return View();
        }


        public IActionResult CancelarCompra(int id)
        {
            if (HttpContext.Session.GetString("rol") == null)
            {
                return Redirect("/Usuario/Login");
            }
            Compra unaC = unS.ObtenerCompra(id);
            if (unaC == null)
            {
                return RedirectToAction("DatosDeCompras");
            }
            ViewBag.Id = id;
            ViewBag.Nombre = unaC.NombreActividad();
            ViewBag.Fecha = unaC.FechaActividad();
            return View();
        }

        [HttpPost]
        public IActionResult CancelarCompra(Compra compra, int id)
        {
            Compra unaC = unS.ObtenerCompra(id);
            if (unS.CancelarLaCompra(unaC, id))
            {
                return Redirect("DatosDeCompras?mensaje=Cancelacion exitosa");
            }
            ViewBag.Mensaje = "No se pudo realizar la cancelación";
            ViewBag.Id = id;
            return View(compra);
        }

        public IActionResult ComprasMayorValor()//View de la o las mayores compras
        {
            if (HttpContext.Session.GetString("rol") == null)
            {
                return Redirect("/Usuario/Login");
            }
            if (HttpContext.Session.GetString("rol") != "Operador")
            {
                return RedirectToAction("ComprasMayorValor");
            }
            ViewBag.Compras = unS.ComprasDeMayorValor();
            return View();
        }


        public IActionResult ComprasPorFecha()
        {
            if (HttpContext.Session.GetString("rol") == null)
            {
                return Redirect("/Usuario/Login");
            }
            if (HttpContext.Session.GetString("rol") != "Operador")
            {
                return RedirectToAction("ComprasPorFecha");
            }
            ViewBag.Compras = unS.Compras;
            return View();
        }

        [HttpPost]
        public IActionResult ComprasPorFecha(DateTime f1, DateTime f2) //Filtro para busqueda
        {
                ViewBag.Compras = unS.Compras;
                ViewBag.CompraPorFecha = unS.ListarComprasPorFecha(f1, f2);
                ViewBag.Fecha1 = f1;
                ViewBag.Fecha2 = f2;
                return View("MostrarComprasPorFecha");
        }
    }
}
