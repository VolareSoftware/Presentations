//using NUnit.Framework;
//using Walkthrough1.Core.Domain.Model;
//using Walkthrough1.Core.Domain.Services;

//namespace Walkthrough1.UnitTests.Core.Domain.Model
//{
//  [TestFixture]
//  public class OrderTests
//  {
//    private Order _order;

//    [SetUp]
//    public void SetUp()
//    {
//      var emailService = new FakeEmailService();
//      _order = new Order(emailService);
//    }

//    [Test]
//    public void Should_return_false_when_using_bad_order_values()
//    {
//      // Arrange
//      _order.FirstName = "Joe";
//      _order.LastName = "Wilson";
//      _order.Email = "joe@volaresystems.com";
//      _order.Total = 0.00m;

//      // Act
//      var result = _order.ProcessOrder();

//      // Assert
//      Assert.That(result, Is.False);
//    }

//    [Test]
//    public void Should_return_true_when_using_good_order_values()
//    {
//      // Arrange
//      _order.FirstName = "Joe";
//      _order.LastName = "Wilson";
//      _order.Email = "joe@volaresystems.com";
//      _order.Total = 123.00m;

//      // Act
//      var result = _order.ProcessOrder();

//      // Assert
//      Assert.That(result, Is.True);
//    }
//  }
//}