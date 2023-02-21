// See https://aka.ms/new-console-template for more information

using MathLib.Calculator;


Calculator calculator = new();
Console.WriteLine("Enter three numbers: ");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int z = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[3] { x, y, z };
Console.WriteLine("Sum: ");
Console.WriteLine(calculator.Add(numbers));