using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            var model = new Login();
            model.mensaje = "" + TempData["mensaje"];
            return View(model);
        }
        [HttpPost]
        public ActionResult Login(Login login)
        {
            if (login.username.Equals("Monitor2019") && login.password.Equals("Operaciones2019"))
            {
                return RedirectToAction("Index", "Menu");
            }
            else
            {
                TempData["mensaje"] = "Usuario y/o contraseña errados";
                return RedirectToAction("Login", "Login");
            }
        }
    }
}
