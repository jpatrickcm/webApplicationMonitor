using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index( Object objeto )
        {
            //TempData["mensaje"] = "";
            return RedirectToAction("Login", "Login");
        }


    }
}