using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;
using Microsoft.AspNetCore.Http;

namespace Obligatorio02.Controllers
{
    public class UsuarioController : Controller
    {
        Sistema unS = Sistema.Instancia;

        public IActionResult InicioBienvenida()
        {
            if (HttpContext.Session.GetString("rol") == null)
            {
                return Redirect("/usuario/login");
            }
            return View();
        }

        public IActionResult ListaClientes()
        {
            if (HttpContext.Session.GetString("rol") == null)
            {
                return Redirect("/usuario/login");
            }
            if (HttpContext.Session.GetString("rol") != "Operador")
            {
                return RedirectToAction("ListaClientes");
            }
            ViewBag.Usuarios = unS.ClientesOrdenadosPorApellido();
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string nombreUsuario, string contrasenia)
        {
            Usuario unU = unS.ObtenerUsuario(nombreUsuario);
            if(unU == null || unU.Contrasenia != contrasenia)
            {
                ViewBag.Mensaje = "Datos incorrectos";
                return View();
            }
            HttpContext.Session.SetString("rol", unU.Rol);
            HttpContext.Session.SetString("nombreUsuario", unU.NombreUsuario);
            return RedirectToAction("InicioBienvenida");
        }

        public IActionResult Registrarse()
        {
            return View(new Usuario());
        }

        [HttpPost]
        public IActionResult Registrarse(Usuario usuario, string contrasenia, string nombreUsuario, string email, string nombre, string apellido)
        {
            if (unS.ValidarContrasenia(contrasenia) == false || unS.ObtenerUsuario(nombreUsuario) != null || unS.ObtenerMail(email) != null || unS.ValidarNombre(nombre) == false|| unS.ValidarApellido(apellido) == false)
            {
                ViewBag.Mensaje = "Datos incorrectos";
                ViewBag.Email = email;
                ViewBag.Nombre = nombre;
                ViewBag.Apellido = apellido;
                ViewBag.NombreUsuario = nombreUsuario;
                return View();
            }
            unS.AgregarUsuario(usuario);
            usuario.Rol = "Cliente";//Le digo que el usuario creado va a ser cliente
            HttpContext.Session.SetString("rol", usuario.Rol);
            HttpContext.Session.SetString("nombreUsuario", usuario.NombreUsuario);
            HttpContext.Session.SetString("mail", usuario.Email);
            return RedirectToAction("InicioBienvenida");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}

