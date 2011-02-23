using System;

namespace Walkthrough1.Core.Domain.Services
{
  public class SalesTaxService
  {
    public decimal GetSalesTax(decimal amountCharged, decimal salesTaxRate)
    {
      var salesTax = amountCharged * salesTaxRate;
      return salesTax;
    }
  }
}