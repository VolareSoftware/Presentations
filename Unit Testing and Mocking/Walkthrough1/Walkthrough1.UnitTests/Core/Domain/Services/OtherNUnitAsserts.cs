using System;
using NUnit.Framework;

namespace Walkthrough1.UnitTests.Core.Domain.Services
{
  [TestFixture]
  public class OtherNUnitAsserts
  {
    [Test]
    public void Examples()
    {
      //// Basics
      //Assert.That(result, Is.True);
      //Assert.That(result, Is.False);
      //Assert.That(result, Is.Empty);
      //Assert.That(result, Is.EqualTo("cat"));
      //Assert.That(result, Is.EqualTo("CAT").IgnoreCase);
      //Assert.That(result, Is.EqualTo(1.234));
      //Assert.That(result, Is.EqualTo(1.234).Within(1.5).Percent);

      //// Ranges
      //Assert.That(result, Is.AtLeast(1));
      //Assert.That(result, Is.AtMost(1));
      //Assert.That(result, Is.GreaterThan(1));
      //Assert.That(result, Is.GreaterThanOrEqualTo(1));
      //Assert.That(result, Is.LessThan(99));
      //Assert.That(result, Is.LessThanOrEqualTo(99));
      //Assert.That(result, Is.GreaterThanOrEqualTo(1).And.LessThanOrEqualTo(99));
      //Assert.That(result, Is.InRange(1, 99));

      //// Objects and types
      //Assert.That(result, Is.Null);
      //Assert.That(result, Is.Not.Null);
      //Assert.That(result, Is.EqualTo(customer));
      //Assert.That(result, Is.InstanceOf(customer.GetType()));
      //Assert.That(result, Is.SameAs(customer));
      //Assert.That(result, Has.Property("myProperty").EqualTo("cat"));

      //// Strings
      //Assert.That(result, Contains.Substring("cat"));
      //Assert.That(result, Is.StringContaining("cat"));
      //Assert.That(result, Is.StringMatching(@"((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}"));
      //Assert.That(result, Is.Not.StringMatching(@"((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}"));
      //Assert.That(result, Is.StringStarting("cat"));
      //Assert.That(result, Is.StringEnding("cat"));

      //// Lists
      //Assert.That(result, Is.SubsetOf(customerList));
      //Assert.That(result, Contains.Item(1));
      //Assert.That(result, Contains.Item("cat"));
      //Assert.That(result, Contains.Item(customer));
      //Assert.That(result, Has.Count.EqualTo(3));
      //Assert.That(result, Has.All.GreaterThan(1));
      //Assert.That(result, Has.All.InstanceOf(customer.GetType()));
      //Assert.That(result, Has.Some.EqualTo(customer));
      //Assert.That(result, Has.None.EqualTo(customer));
      //Assert.That(result, Has.Member(customer));

      //// Exceptions
      //Assert.That(_service.GetSalesTax, Throws.Exception.TypeOf<NullReferenceException>());

      //// Paths
      //Assert.That(result, Is.SamePath(filePath));
      //Assert.That(result, Is.SamePathOrUnder(filePath));
    }
  }
}