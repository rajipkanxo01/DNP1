// See https://aka.ms/new-console-template for more information


using Polymorphism;

Company company = new();
Employee employee1 = new FullTimeEmployee("Rajib", 20000);
Employee employee2 = new FullTimeEmployee("Suhani", 22000);
Employee employee3 = new FullTimeEmployee("Pramesh", 30000);
Employee employee4 = new PartTimeEmployee("Pangey", 49, 60);
company.HireNewEmployee(employee1);
company.HireNewEmployee(employee2);
company.HireNewEmployee(employee3);
company.HireNewEmployee(employee4);

Console.WriteLine(company.GetMonthlySalaryTotal());