using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practica1.Controllers
{
    public class PersonalController : Controller
    {
        // GET: Personal
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Asignaturas()
        {
            return View();
        }

        public ActionResult Pasatiempos()
        {
            return View();
        }

        public ActionResult PeliculasFaboritas()
        {
            return View();
        }
    }
}