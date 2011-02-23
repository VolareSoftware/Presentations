using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using Lab4.ApplicationServices.Services;

namespace Lab4.Controllers
{
  public class EmployeeController : Controller
  {
    // Lab #4, Step #5b
    //private readonly IEmployeeService _applicationService;

    // Lab #4, Step #5b
    // Don't need this constructor if using IOC container
    //public EmployeeController()
    //  : this(new EmployeeService())
    //{
    //}

    // Lab #4, Step #5b
    //public EmployeeController(IEmployeeService applicationService)
    //{
    //  _applicationService = applicationService;
    //}


    // GET: /Employee/

    public ActionResult Index()
    {
      return View();

      // Lab #4, Step #5c
      //var employeeViewModels = _applicationService.GetAll();

      // Lab #4, Step #5c
      //return View(employeeViewModels);
    }

    //
    // GET: /Employee/Details/5

    public ActionResult Details(int id)
    {
      return View();

      // Lab #4, Step #8
      //var employeeViewModel = _applicationService.Get(id);

      // Lab #4, Step #8
      //return View(employeeViewModel);
    }

    //
    // GET: /Employee/Create

    public ActionResult Create()
    {
      return View();
    }

    //
    // POST: /Employee/Create

    [AcceptVerbs(HttpVerbs.Post)]
    public ActionResult Create(FormCollection collection)
    {
      try
      {
        // TODO: Add insert logic here

        return RedirectToAction("Index");
      }
      catch
      {
        return View();
      }
    }

    //
    // GET: /Employee/Edit/5

    public ActionResult Edit(int id)
    {
      return View();
    }

    //
    // POST: /Employee/Edit/5

    [AcceptVerbs(HttpVerbs.Post)]
    public ActionResult Edit(int id, FormCollection collection)
    {
      try
      {
        // TODO: Add update logic here

        return RedirectToAction("Index");
      }
      catch
      {
        return View();
      }
    }
  }
}
