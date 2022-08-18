
namespace Library_SRP.Employee
{
    public interface IEmployee
    {
        string Name { get; set; }
        int Age { get; set; }
        double WorkingHoursPerWeek { get; set; }
        double Salary { get; set; }
    }
}
