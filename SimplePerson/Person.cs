namespace SimplePerson;

public class Person
{
    public string Name { get; set; }

    public void Introduce()
    {
        Console.WriteLine($"Hello from {Name}");
    }
}