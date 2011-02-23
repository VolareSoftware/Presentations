using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using Lab1.Models;

namespace Lab1.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Welcome to ASP.NET MVC!";

            return View();
        }

        // Lab #1, Step #3
        //public ActionResult Index()
        //{
        //    ViewData["Message"] = "Hello World from Controller!";

        //    return View();
        //}

        // Lab #1, Step #4c
        //public ActionResult Index()
        //{
        //    var model = new HomeViewModel();
        //    model.Message = "Hellow World from Model!";

        //    return View(model);
        //}

        public ActionResult About()
        {
            return View();
        }
    }
}
