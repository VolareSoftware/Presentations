using System.Collections.Generic;
using Lab4.ApplicationServices.ViewModel;
using Lab4.Core.Domain.Model;

namespace Lab4.ApplicationServices.Services
{
  public interface IEmployeeService
  {
    List<EmployeeViewModel> GetAll();
    EmployeeViewModel Get(int id);
    // Could have something else here, like Save
    //bool Save(EmployeeViewModel employee);
  }
}