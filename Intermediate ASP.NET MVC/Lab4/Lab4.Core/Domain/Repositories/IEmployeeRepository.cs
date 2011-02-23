using System.Collections.Generic;
using Lab4.Core.Domain.Model;

namespace Lab4.Core.Domain.Repositories
{
  public interface IEmployeeRepository
  {
    List<Employee> GetAll();
    Employee Get(int id);
    // Could have something else here, like Insert, Update, and Delete
    //bool Insert(Employee employee);
    //bool Update(Employee employee);
    //bool Delete(Employee employee);
    //bool Delete(int id);
  }
}