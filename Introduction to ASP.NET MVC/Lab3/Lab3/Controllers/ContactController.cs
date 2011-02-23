using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using Lab3.Models;

namespace Lab3.Controllers
{
    public class ContactController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Index(ContactViewModel model)
        {
            try
            {
                model.Save();

                // Lab #3, Step #7
                //if (!ModelState.IsValid)
                //{
                //    return View();
                //}
                //else
                //{
                //    model.Save();
                //}

                return RedirectToAction("Success", model);
            }
            catch
            {
                return View();
            }
        }
        
        public ActionResult Success(ContactViewModel model)
        {
            return View(model);
        }
    }
}
