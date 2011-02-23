using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloWorld.Models;

namespace HelloWorld.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Welcome to ASP.NET MVC!";

            return View();
        }

        // Step #4
        //public ActionResult Index()
        //{
        //    ViewData["Message"] = "Hello World from Controller!";

        //    return View();
        //}

        // Step #5c
        //public ActionResult Index()
        //{
        //    var model = new HomeViewModel();
        //    model.Message = "Hello World from Model!";

        //    return View(model);
        //}
        
        public ActionResult About()
        {
            return View();
        }
    }
}
