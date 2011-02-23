using System;
using System.Net.Mail;
using Walkthrough1.Core.Domain.Model;

namespace Walkthrough1.Core.Domain.Services
{
  public class EmailService
  {
    public bool SendOrderConfirmationEmail(Order order)
    {
      var result = false;

      try
      {
        var from = "joe@volaresystems.com";
        var to = order.Email;
        var subject = "Order Confirmation";
        var body = string.Format("Thanks for your order of {0}.", order.Total);
        var message = new MailMessage(from, to, subject, body);

        var smtp = new SmtpClient();
        smtp.Send(message);

        result = true;
      }
      catch (SmtpException smtpException)
      {
        result = false;
      }

      return result;
    }
  }
}
