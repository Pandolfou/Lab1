using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab1.Models;

namespace Lab1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Il vous est possible de faire des frites";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Pourquoi pas des patates pilées?";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Bah! patate au four c'est bien correct";

            return View();
        }
        public ActionResult Achat()
        {
            ViewBag.Message = "T'es un fou!";
            return View();
        }

        [HttpPost]
        public ActionResult Achat(ClasseAchat a)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
