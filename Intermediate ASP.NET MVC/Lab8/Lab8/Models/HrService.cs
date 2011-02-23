using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace Lab8.Models
{
  public class HrService : IHrService
  {
    public List<Department> GetAllDepartments()
    {
      // This is to slow it down to pretend we're hitting an HR web service
      Thread.Sleep(2000);

      var departments = new List<Department>
                          {
                            new Department
                              {
                                Name = "Human Resources"
                              },
                            new Department
                              {
                                Name = "Accounting"
                              },
                            new Department
                              {
                                Name = "IT"
                              },
                            new Department
                              {
                                Name = "Pencil Sharpening"
                              }
                          };

      return departments;
    }
  }
}
