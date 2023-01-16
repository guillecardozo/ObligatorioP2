using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;
using Microsoft.AspNetCore.Http;

namespace Obligatorio02.Controllers
{
    public class ActividadController : Controller
    {
        Sistema unS = Sistema.Instancia;

        public IActionResult ListaActividadUsuarioAnonimo()//View de la lista de actividades con el precio
        {
            ViewBag.Actividades = unS.Actividades;
            return View();
        }


        public IActionResult ListaActividadUsuarioCliente(string mensaje)//View de la lista de actividades, con boton de compra y likes
        {
            if (HttpContext.Session.GetString("rol") == null)
            {
                return Redirect("/Usuario/Login");
            }
            if (HttpContext.Session.GetString("rol") != "Cliente")
            {
                return RedirectToAction("ListaActividadUsuarioCliente");
            }
                ViewBag.Actividades = unS.Actividades;
                ViewBag.Mensaje = mensaje;
                return View(new Compra());
        }

        
        public IActionResult ListaActividadesPorLugar()//View de una lista de actividades por lugar
        {
            if (HttpContext.Session.GetString("rol") == null)
            {
                return Redirect("/Usuario/Login");
            }
            if (HttpContext.Session.GetString("rol") != "Operador")
            {
                return RedirectToAction("ListaActividadesPorLugar");
            }
            ViewBag.Lugares = unS.Lugares;
            ViewBag.ActividadesLugar = unS.Actividades;
            //ViewBag.Mensaje = mensaje;
            return View();
        }


        [HttpPost]
        public IActionResult ListaActividadesPorLugar(string nombreLugar) //Filtro para busqueda
        {
            if (unS.ObtenerLugar(nombreLugar) != null) //Genero una funcion que comprueba si existe el lugar por nombre
            {
                ViewBag.Lugares = unS.Lugares;
                ViewBag.ActividadesLugar = unS.ActividadPorLugar(nombreLugar);
                return View("MostrarActividadesPorLugar");
            }
            return RedirectToAction("ListaActividadesPorLugar");
        }


        public IActionResult ListaActividadesDeCategoriaPorFecha()//View de una lista de actividades de una categoria por fecha
        {
            if (HttpContext.Session.GetString("rol") == null)
            {
                return Redirect("/Usuario/Login");
            }
            if (HttpContext.Session.GetString("rol") != "Operador")
            {
                return RedirectToAction("ListaActividadesDeCategoriaPorFecha");
            }
            ViewBag.Categorias = unS.Categorias;
            ViewBag.ActividadesLugar = unS.Actividades;
            //ViewBag.Mensaje = mensaje;
            return View();
        }

        [HttpPost]
        public IActionResult ListaActividadesDeCategoriaPorFecha(string nombreCategoria, DateTime f1, DateTime f2) //Filtro para busqueda
        {
            if (unS.ObtenerCategoria(nombreCategoria) != null) //Genero una funcion que comprueba si existe la categoria por nombre
            {
                ViewBag.Categorias = unS.Categorias;
                ViewBag.ActividadesCategoria = unS.ActividadPorCategoria(nombreCategoria, f1, f2);
                ViewBag.Fecha1 = f1;
                ViewBag.Fecha2 = f2;
                return View("MostrarActividadesPorCategoria");
            }
            //ViewBag.Mensaje = mensaje;
            return RedirectToAction("ListaActividadesDeCategoriaPorFecha");
        }


        public IActionResult DarMeGusta(int id)
        {
            Actividad unaA = unS.ObtenerActividad(id);

            if (unaA == null)
            {
                return RedirectToAction("ListaActividadUsuarioCliente");//Me lleva al metodo en el controlador de actividad
            }
            ViewBag.Id = id;
            ViewBag.Nombre = unaA.Nombre;
            ViewBag.Fecha = unaA.Fecha;
            return View();
        }

        [HttpPost]
        public IActionResult DarMeGusta(Actividad actividad, int id)
        {
            Actividad unaA = unS.ObtenerActividad(id);
            if (unaA != null)
            {
                unS.IncrementarMeGusta(id);
            }
                return RedirectToAction("ListaActividadUsuarioCliente");
        }

        /*Prueba para la defensa*/
        public IActionResult Defensa()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Defensa(string nombre)
        {

            ViewBag.Metodo = unS.MetodoDefensa(nombre);
            
            return View();
        }

    }
}
