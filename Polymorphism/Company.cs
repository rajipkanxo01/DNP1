namespace Polymorphism;

public class Company
{
    private List<Employee> employees = new List<Employee>();

    public void HireNewEmployee(Employee employee)
    {
        employees.Add(employee);
    }

    
    public double GetMonthlySalaryTotal()
    {
        double totalSalary = 0;
        foreach (Employee employee in employees)
        {
            totalSalary += employee.GetMonthlySalary();
        }

        return totalSalary;
    }
}