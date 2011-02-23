//using NUnit.Framework;
//using Rhino.Mocks;
//using Walkthrough1.Core.Domain.Model;
//using Walkthrough1.Core.Domain.Repositories;
//using Walkthrough1.Core.Domain.Services;

//namespace Walkthrough1.UnitTests.Core.Domain.Model
//{
//  [TestFixture]
//  public class OrderTests
//  {
//    #region SetUp

//    private IEmailService _emailService;
//    private IOrderRepository _repository;

//    [SetUp]
//    public void SetUp()
//    {
//      _emailService = MockRepository.GenerateMock<IEmailService>();
//      _emailService
//        .Stub(x => x.SendOrderConfirmationEmail(Arg<Order>.Is.Anything))
//        .Return(true);

//      _repository = MockRepository.GenerateMock<IOrderRepository>();
//    }

//    private Order GetGoodOrder()
//    {
//      var order = new Order(_emailService, _repository);
//      order.FirstName = "Joe";
//      order.LastName = "Wilson";
//      order.Email = "joe@volaresystems.com";
//      order.Total = 123.00m;

//      return order;
//    }

//    #endregion

//    [Test]
//    public void Should_return_false_when_using_bad_order_values()
//    {
//      // Arrange
//      var order = GetGoodOrder();
//      order.Total = 0.00m; // Bad amount

//      // Act
//      var result = order.ProcessOrder();

//      // Assert
//      Assert.That(result, Is.False);
//      _repository.AssertWasNotCalled(x => x.Save(order));
//    }

//    [Test]
//    public void Should_return_true_when_using_good_order_values()
//    {
//      // Arrange
//      var order = GetGoodOrder();

//      // Act
//      var result = order.ProcessOrder();

//      // Assert
//      Assert.That(result, Is.True);
//      _repository.AssertWasCalled(x => x.Save(order));
//    }
//  }
//}