using System;
using System.Collections.Generic;
using Lab4.Core.Domain.Model;
using Lab4.Core.Domain.Repositories;

namespace Lab4.Infrastructure.Data.Repositories
{
  public class EmployeeRepository : IEmployeeRepository
  {
    // Lab #4, Step #5a
    public List<Employee> GetAll()
    {
      // This would not be needed if we had a database
      var employees = new List<Employee>
                                {
                                    new Employee
                                        {
                                            Id = 1,
                                            FirstName = "Joe",
                                            LastName = "Wilson",
                                            Department = "IT",
                                            StartDate = new DateTime(2005, 5, 5)
                                        },
                                    new Employee
                                        {
                                            Id = 2,
                                            FirstName = "Test First",
                                            LastName = "Test Last",
                                            Department = "Test Dept",
                                            StartDate = new DateTime(2007, 7, 7)
                                        }
                                };

      return employees;
    }

    // Lab #4, Step #5a
    public Employee Get(int id)
    {
      // This would not be needed if we had a database
      var employees = GetAll();

      // Pretend fetch from database by ID
      var employee = employees.Find(x => x.Id == id);

      return employee;
    }
  }
}