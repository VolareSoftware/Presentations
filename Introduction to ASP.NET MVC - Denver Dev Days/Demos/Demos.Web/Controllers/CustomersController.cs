using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Demos.Web.Models;

namespace Demos.Web.Controllers
{
    //[Authorize(Roles = "Admins, MyDemoUsers")]
    public class CustomersController : Controller
    {
        public ActionResult Edit()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Edit(Customer customer)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        // Booo!!!  Bad values - Redirect to fix it
        //        return RedirectToAction("Edit");
        //    }

        //    // Yay!!! Good values - Set TempData values and redirect to review screen
        //    // ... or you could redirect to a Customer list
        //    // ... or redirect to next step in process
        //    TempData["Message"] = "That worked, " + customer.FullName + "!";
        //    return RedirectToAction("Review");
        //}

        //public ActionResult Review()
        //{
        //    return View();
        //}
    }
}