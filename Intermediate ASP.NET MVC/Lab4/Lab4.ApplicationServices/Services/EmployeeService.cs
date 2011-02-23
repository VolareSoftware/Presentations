using System.Collections.Generic;
using System.Linq;
using Lab4.ApplicationServices.ViewModel;
using Lab4.Core.Domain.Repositories;
using Lab4.Infrastructure.Data.Repositories;

namespace Lab4.ApplicationServices.Services
{
  public class EmployeeService : IEmployeeService
  {
    private readonly IEmployeeRepository _repository;

    // Don't need this constructor if using IOC container
    public EmployeeService()
      : this(new EmployeeRepository())
    {
    }

    public EmployeeService(IEmployeeRepository repository)
    {
      _repository = repository;
    }

    public List<EmployeeViewModel> GetAll()
    {
      var employees = _repository.GetAll();

      // Would normall use AutoMapper here
      var employeeViewModels = from employee in employees
                               select new EmployeeViewModel
                                          {
                                            Id = employee.Id,
                                            FirstName = employee.FirstName,
                                            LastName = employee.LastName,
                                            FullName = employee.FirstName + "" + employee.LastName,
                                            Department = employee.Department,
                                          };

      return employeeViewModels.ToList();
    }

    public EmployeeViewModel Get(int id)
    {
      var employee = _repository.Get(id);

      // Would normall use AutoMapper here
      var employeeViewModel = new EmployeeViewModel
                                  {
                                    Id = employee.Id,
                                    FirstName = employee.FirstName,
                                    LastName = employee.LastName,
                                    FullName = employee.FirstName + "" + employee.LastName,
                                    Department = employee.Department,
                                  };

      return employeeViewModel;
    }
  }
}
