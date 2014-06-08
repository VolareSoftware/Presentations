using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Demos.Web.Models;

namespace Demos.Web.Controllers
{
    [Authorize(Roles = "Admins, MyDemoUsers")]
    public class CustomersController : Controller
    {
        public ActionResult Edit()
        {
            var customer = new Customer();

            return View(customer);
        }

        //[HttpPost]
        //public ActionResult Edit(Customer customer)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        // Booo!!!  Bad values - Redirect to fix it
        //        return RedirectToAction("Edit");
        //    }

        //    // Yay!!! Good values - Show values for review
        //    // ... or you could redirect to a Customer list
        //    // ... or redirect to next step in process
        //    return View(customer);
        //}
    }
}