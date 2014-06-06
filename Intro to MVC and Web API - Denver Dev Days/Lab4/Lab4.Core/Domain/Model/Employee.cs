using System;

namespace Lab4.Core.Domain.Model
{
  public class Employee
  {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Department { get; set; }
    public DateTime StartDate { get; set; }
    public decimal Salary { get; set; }
  }
}