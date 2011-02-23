using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Routing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcContrib.TestHelper;
using Testing.Controllers;

namespace Testing.Tests
{
    [TestClass]
    public class RoutingTests
    {
        [TestInitialize]
        public void SetUp()
        {
            RouteTable.Routes.Clear();
            MvcApplication.RegisterRoutes(RouteTable.Routes);
        }

        [TestMethod]
        public void Should_map_Home_Index_routes_correctly()
        {
            "~/".ShouldMapTo<HomeController>(x => x.Index());

            "~/Home".ShouldMapTo<HomeController>(x => x.Index());

            "~/Home/Index".ShouldMapTo<HomeController>(x => x.Index());
        }

        [TestMethod]
        public void Should_map_Home_About_routes_correctly()
        {
            "~/Home/About".ShouldMapTo<HomeController>(x => x.About());

            "~/Home/About/Index".ShouldMapTo<HomeController>(x => x.About());
        }

        [TestMethod]
        public void Should_map_This_Is_So_Cool_route_correctly()
        {
            "~/This/Is/So/Cool".ShouldMapTo<HomeController>(x => x.About());
        }
    }
}
