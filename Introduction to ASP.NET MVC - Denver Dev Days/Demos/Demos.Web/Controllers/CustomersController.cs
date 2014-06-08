using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
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
        //        // Booo!!!  Bad values - Redirect!
        //        return RedirectToAction("Edit");
        //    }

        //    // Yay!!! Good values
        //    return View();
        //}
    }
}