namespace Polymorphism;

public class Employee
{
    public string Name { get; set; }

    public Employee(string name)
    {
        Name = name;
    }

    public virtual double GetMonthlySalary()
    {
        return 0;
    }

    
}