using System.Web.Routing;
using Lab5.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcContrib.TestHelper;

namespace Lab5.Tests
{
    // Lab #5, Step #5
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

            // Lab #5, Step #6
            //"~/This/Is/So/Cool".ShouldMapTo<HomeController>(x => x.About());
        }
    }
}
