using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab7.Controllers
{
  [HandleError]
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      // Lab #7, Step #3
      //var x = 0;
      //var y = 1;
      //var z = y / x;

      ViewData["Message"] = "Welcome to ASP.NET MVC!";

      return View();
    }

    public ActionResult About()
    {
      return View();
    }
  }
}
