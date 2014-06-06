using System;

namespace Lab4.ApplicationServices.ViewModel
{
  public class EmployeeViewModel
  {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    // This is in the view model, but not needed in the domain
    public string FullName { get; set; }
    public string Department { get; set; }
    // These are in the domain model, but not needed for view
    //public DateTime StartDate { get; set; }
    //public decimal Salary { get; set; }
  }
}