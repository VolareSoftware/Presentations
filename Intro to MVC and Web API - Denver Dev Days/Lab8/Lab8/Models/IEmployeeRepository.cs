using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab8.Models
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAll();
        Employee Get(int id);
    }
}
