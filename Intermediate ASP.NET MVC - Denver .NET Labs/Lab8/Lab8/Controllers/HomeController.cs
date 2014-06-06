using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab8.Models;

namespace Lab8.Controllers
{
  [HandleError]
  public class HomeController : Controller
  {
    // Lab #8, Step #4
    //private readonly IHrService _service;

    //public HomeController(): this(new HrService())
    //{
    //}

    //public HomeController(IHrService service)
    //{
    //  _service = service;
    //}

    public ActionResult Index()
    {
      ViewData["Message"] = "Welcome to ASP.NET MVC!";

      return View();
    }

    public ActionResult About()
    {
      return View();
    }

    // Lab #8, Step #3
    //public JsonResult GetAllDepartments()
    //{
    //  var departments = _service.GetAllDepartments();

    //  return Json(departments);
    //}

  }
}