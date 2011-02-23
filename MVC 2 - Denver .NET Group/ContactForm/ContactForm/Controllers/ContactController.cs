using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContactForm.Models;

namespace ContactForm.Controllers
{
    public class ContactController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(ContactViewModel model)
        {
            // Step 8
            //if (ModelState.IsValid)
            //{
                model.Save();
                return View("Success", model);
            //}
            //else
            //{
            //    return View();
            //}
        }
    }
}
