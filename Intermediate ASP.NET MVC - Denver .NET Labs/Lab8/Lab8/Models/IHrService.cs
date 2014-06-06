using System.Collections.Generic;

namespace Lab8.Models
{
  public interface IHrService
  {
    List<Department> GetAllDepartments();
  }
}