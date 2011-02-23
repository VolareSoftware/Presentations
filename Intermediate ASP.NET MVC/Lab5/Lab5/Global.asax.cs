using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Lab5
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Lab #5, Step #6
            // Old About route is http://localhost/Home/About
            // For new route, we want http://localhost/This/Is/So/Cool
            //routes.MapRoute(
            //    "About",                                                // Route name
            //    "This/Is/So/Cool",                                      // URL with parameters
            //    new { controller = "Home", action = "About", id = "" }  // Parameter defaults
            //);

            routes.MapRoute(
                "Default",                                              // Route name
                "{controller}/{action}/{id}",                           // URL with parameters
                new { controller = "Home", action = "Index", id = "" }  // Parameter defaults
            );
        }

        protected void Application_Start()
        {
            RegisterRoutes(RouteTable.Routes);
        }
    }
}