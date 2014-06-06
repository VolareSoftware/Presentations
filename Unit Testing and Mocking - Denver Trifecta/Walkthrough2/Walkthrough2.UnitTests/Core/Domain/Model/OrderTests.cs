using NUnit.Framework;
using Walkthrough1.Core.Domain.Model;
using Walkthrough1.Core.Domain.Services;

namespace Walkthrough1.UnitTests.Core.Domain.Model
{
  [TestFixture]
  public class OrderTests
  {
    [Test]
    public void Should_return_false_when_using_bad_order_values()
    {
      // Arrange
      var order = new Order();
      order.FirstName = "Joe";
      order.LastName = "Wilson";
      order.Email = "joe@volaresystems.com";
      order.Total = 0.00m; // Bad amount

      // Act
      var result = order.ProcessOrder();

      // Assert
      Assert.That(result, Is.False);
    }

    [Test]
    public void Should_return_true_when_using_good_order_values()
    {
      // Arrange
      var order = new Order();
      order.FirstName = "Joe";
      order.LastName = "Wilson";
      order.Email = "joe@volaresystems.com";
      order.Total = 123.00m; // Good amount

      // Act
      // TODO: Watch out!  Don't run this or it will send real emails!
      var result = order.ProcessOrder();

      // Assert
      Assert.That(result, Is.True);
    }
  }
}