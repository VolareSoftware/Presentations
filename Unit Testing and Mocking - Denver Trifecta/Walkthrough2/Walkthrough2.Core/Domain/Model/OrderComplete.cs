//using System;
//using Walkthrough1.Core.Domain.Services;

//namespace Walkthrough1.Core.Domain.Model
//{
//  public class Order
//  {
//    private readonly IEmailService _emailService;

//    public string FirstName { get; set; }
//    public string LastName { get; set; }
//    public string Email { get; set; }
//    public decimal Total { get; set; }

//    public Order(IEmailService emailService)
//    {
//      _emailService = emailService;
//    }

//    public bool ProcessOrder()
//    {
//      var result = false;
      
//      // Validate order
//      if (!string.IsNullOrEmpty(this.Email) && this.Total > 0)
//      {
//        // Send order confirmation email
//        //var emailService = new EmailService();
//        var emailSendResult = _emailService.SendOrderConfirmationEmail(this);

//        if (emailSendResult == true)
//        {
//          // Save to the database

//          // Do more order processing...

//          result = true;
//        }
//      }

//      return result;
//    }
//  }
//}