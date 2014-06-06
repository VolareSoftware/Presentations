//using NUnit.Framework;
//using Walkthrough1.Core.Domain.Services;

//namespace Walkthrough1.UnitTests.Core.Domain.Services
//{
//  [TestFixture]
//  public class SalesTaxServiceTests
//  {
//    [Test]
//    public void Should_return_zero_sales_tax_with_rate_of_zero()
//    {
//      // Arrange
//      var service = new SalesTaxService();
//      decimal amountCharged = 100.00m;
//      decimal salesTaxRate = 0.00m;

//      // Act
//      var result = service.GetSalesTax(amountCharged, salesTaxRate);

//      // Assert
//      Assert.That(result, Is.EqualTo(0));
//    }

//    [Test]
//    public void Should_return_correct_sales_tax_with_good_rate()
//    {
//      // Arrange
//      var service = new SalesTaxService();
//      decimal amountCharged = 100.00m;
//      decimal salesTaxRate = 0.05m;

//      // Act
//      var result = service.GetSalesTax(amountCharged, salesTaxRate);

//      // Assert
//      Assert.That(result, Is.EqualTo(5.00));
//    }
//  }
//}