using Walkthrough1.Core.Domain.Model;

namespace Walkthrough1.Core.Domain.Services
{
  public interface IEmailService
  {
    bool SendOrderConfirmationEmail(Order order);
  }
}