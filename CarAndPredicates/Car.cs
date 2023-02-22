namespace CarAndPredicates;

public class Car
{
    public string Color { get; set; }
    public double EngineSize { get; set; }
    public double FuelEconomy { get; set; }
    public bool IsManualShift { get; set; }

    public Car(string color, double engineSize, double fuelEconomy, bool isManualShift)
    {
        Color = color;
        EngineSize = engineSize;
        FuelEconomy = fuelEconomy;
        IsManualShift = isManualShift;
    }

    public static List<Car> GenerateRandomCars()
    {
        List<Car> cars = new();
        string[] colors = new[] { "Red","Blue","Green","Yellow","White" };
        double[] engineSize = new double[] { 1.0,1.6,2.0,2.5 };
        double[] fuelEconomy = new double[] { 3, 7, 4.5, 4.7, 5.3, 5.0 };
        bool[] isManual = new bool[] { true, false };
        Random random = new Random();

        for (int i = 0; i < 6; i++)
        {
            cars.Add(new Car(colors[random.Next(colors.Length)], engineSize[random.Next(engineSize.Length)],
                fuelEconomy[random.Next(fuelEconomy.Length)],
                isManual[random.Next(isManual.Length)]));
        }

        return cars;
    }

    public override string ToString()
    {
        return
            $"Color: {Color} \t Engine Size: {EngineSize} \t Fuel Economy: {FuelEconomy} \t IsManualShift: {IsManualShift}";
    }
}