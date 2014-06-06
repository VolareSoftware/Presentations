using Walkthrough1.Core.Domain.Repositories;
using Walkthrough1.Core.Domain.Services;

namespace Walkthrough1.Core.Domain.Model
{
  public class Order
  {
    private readonly IEmailService _emailService;
    private readonly IOrderRepository _repository;

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public decimal Total { get; set; }

    public Order(IEmailService emailService)
    {
      _emailService = emailService;
    }

    //public Order(IEmailService emailService, IOrderRepository repository)
    //{
    //  _emailService = emailService;
    //  _repository = repository;
    //}

    public bool ProcessOrder()
    {
      var result = false;

      // Validate order
      if (!string.IsNullOrEmpty(this.Email) && this.Total > 0)
      {
        // Send order confirmation email
        var emailSendResult = _emailService.SendOrderConfirmationEmail(this);

        if (emailSendResult == true)
        {
          // Save to the database
          //_repository.Save(this);

          // Do more order processing...

          result = true;
        }
      }

      return result;
    }
  }
}