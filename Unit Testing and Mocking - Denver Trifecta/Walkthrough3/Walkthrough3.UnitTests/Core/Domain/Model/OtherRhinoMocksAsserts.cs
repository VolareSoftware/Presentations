using System.Net.Mail;
using NUnit.Framework;
using Rhino.Mocks;
using Walkthrough1.Core.Domain.Model;
using Walkthrough1.Core.Domain.Repositories;
using Walkthrough1.Core.Domain.Services;

namespace Walkthrough1.UnitTests.Core.Domain.Model
{
  [TestFixture]
  public class OtherRhinoMocksAsserts
  {
    #region SetUp

    private IEmailService _emailService;
    private IOrderRepository _repository;

    [SetUp]
    public void SetUp()
    {
      _emailService = MockRepository.GenerateMock<IEmailService>();
      _emailService
        .Stub(x => x.SendOrderConfirmationEmail(Arg<Order>.Is.Anything))
        .Return(true);

      _repository = MockRepository.GenerateMock<IOrderRepository>();
    }

    #endregion

    [Test]
    public void Examples()
    {
      // Simulate an exception being thrown
      _emailService
        .Stub(x => x.SendOrderConfirmationEmail(Arg<Order>.Is.Anything))
        .Throw(new SmtpException());

      // Assert was called
      _repository.AssertWasCalled(x => x.Save(Arg<Order>.Is.Anything));
      _repository.AssertWasCalled(x => x.Save(null),
                                  opt => opt.IgnoreArguments());

      // Assert was NOT called
      _repository.AssertWasNotCalled(x => x.Save(Arg<Order>.Is.Anything));
      _repository.AssertWasNotCalled(x => x.Save(null),
                                     opt => opt.IgnoreArguments());

    }
  }
}