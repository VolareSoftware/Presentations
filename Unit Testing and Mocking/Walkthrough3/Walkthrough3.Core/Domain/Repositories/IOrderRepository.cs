using Walkthrough1.Core.Domain.Model;

namespace Walkthrough1.Core.Domain.Repositories
{
  public interface IOrderRepository
  {
    void Save(Order order);
  }
}