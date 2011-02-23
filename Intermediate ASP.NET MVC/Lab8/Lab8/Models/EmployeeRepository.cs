using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab8.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
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
