// See https://aka.ms/new-console-template for more information

using CarAndPredicates;

string[] colors = new[] { "Red,Yellow,White" };
List<Car> cars = Car.GenerateRandomCars();
List<Car> carsWithGreenColor = cars.Where(car => car.Color.Equals("Green")).ToList();
// List<Car> carsWithArraysOfColor = cars.Where(car => car.Color.Equals(colors)).ToList();
List<Car> carsWithEngineSizeBiggerThan2L = cars.Where(car => car.EngineSize >= 2).ToList();
List<Car> carsWithFuelEconomyMoreThan3AndManualShift =
    cars.Where(car => car.FuelEconomy >= 3 && car.IsManualShift).ToList();

Console.WriteLine("\n All Cars: ");
foreach (Car car in cars)
{
    Console.WriteLine(car);
}

Console.WriteLine("\n Cars With Green Color ");
foreach (Car car in carsWithGreenColor)
{
    Console.WriteLine(car);
}

Console.WriteLine("\n Cars With Engine Size Bigger Than 2 ");
foreach (Car car in carsWithEngineSizeBiggerThan2L)
{
    Console.WriteLine(car);
}

Console.WriteLine("\n Cars With Fuel Economy More than 3 and Having Manual Shift ");
foreach (Car car in carsWithFuelEconomyMoreThan3AndManualShift)
{
    Console.WriteLine(car);
}

// Console.WriteLine("\n Cars With Array of Colors ");
// {
//     foreach (Car car in carsWithArraysOfColor)
//         Console.WriteLine(car);
// }