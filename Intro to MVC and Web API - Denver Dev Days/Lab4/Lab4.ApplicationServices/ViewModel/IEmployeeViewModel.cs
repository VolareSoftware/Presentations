namespace Lab4.ApplicationServices.ViewModel
{
  public interface IEmployeeViewModel
  {
    int Id { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
    string FullName { get; set; }
    string Department { get; set; }
  }
}