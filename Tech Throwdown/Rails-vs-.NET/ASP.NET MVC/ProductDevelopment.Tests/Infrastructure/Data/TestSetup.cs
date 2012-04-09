using System.Transactions;
using NUnit.Framework;

namespace ProductDevelopment.Tests.Infrastructure.Data
{
    [SetUpFixture]
    public class TestSetup
    {
        private TransactionScope scope;

        [SetUp]
        public void Setup()
        {
            //scope = new TransactionScope(TransactionScopeOption.RequiresNew,
            //  new TransactionOptions()
            //  {
            //      IsolationLevel = IsolationLevel.ReadUncommitted
            //  });
        }

        [TearDown]
        public void TearDown()
        {
            if (scope != null)
            {
                scope.Dispose();
                scope = null;
            }
        }
    }
}