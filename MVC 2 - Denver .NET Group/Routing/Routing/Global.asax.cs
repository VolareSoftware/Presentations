using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Routing
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Step #7
            // Old About route is http://localhost/Home/About
            // For new route, we want http://localhost/This/Is/So/Cool
            //routes.MapRoute(
            //    "RoutingTest", // Route name
            //    "This/Is/So/Cool", // URL with parameters
            //    new { controller = "Home", action = "About", id = UrlParameter.Optional } // Parameter defaults
            //);
            
            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

            // Step #4
            // Old About route is http://localhost/Home/About
            // For new route, we want http://localhost/This/Is/So/Cool
            //routes.MapRoute(
            //    "RoutingTest", // Route name
            //    "This/Is/So/Cool", // URL with parameters
            //    new { controller = "Home", action = "About", id = UrlParameter.Optional } // Parameter defaults
            //);

        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterRoutes(RouteTable.Routes);
        }
    }
}