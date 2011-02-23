using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using Lab2.Models;

namespace Lab2.Controllers
{
    public class ContactController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        // Lab #2, Step #2
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Index(FormCollection collection)
        {
            try
            {
                var model = new ContactViewModel();
                model.FirstName = collection["FirstName"];
                model.LastName = collection["LastName"];
                model.Phone = collection["Phone"];
                model.Email = collection["Email"];
                model.Save();

                return RedirectToAction("Index");

                // Lab #2, Step #6
                //return RedirectToAction("Success", model);
            }
            catch
            {
                return View();
            }
        }

        // Lab #2, Step #7
        //[AcceptVerbs(HttpVerbs.Post)]
        //public ActionResult Index(ContactViewModel model)
        //{
        //    try
        //    {
        //        //var model = new ContactViewModel();
        //        //model.FirstName = collection["FirstName"];
        //        //model.LastName = collection["LastName"];
        //        //model.Phone = collection["Phone"];
        //        //model.Email = collection["Email"];
        //        model.Save();

        //        //return RedirectToAction("Index");

        //        // Lab #2, Step #6
        //        return RedirectToAction("Success", model);
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // Lab #2, Step #6b
        //public ActionResult Success(ContactViewModel model)
        //{
        //    return View(model);
        //}
    }
}
