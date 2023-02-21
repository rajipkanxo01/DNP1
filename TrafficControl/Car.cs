namespace TrafficControl;

public class Car
{
    private int id;

    public Car(TrafficLight tl, int id)
    {
        this.id = id;
        // subscribe a listener
        tl.OnLightChange += ReactToLight;
    }

    public void ReactToLight(string color)
    {
        string result = $"Car {id} ";
        switch (color)
        {
            case "GREEN":
                result += " drives";
                break;
            case "YELLOW":
                result += " slows";
                break;
            case "RED":
                result += " stops";
                break;
        }

        Console.WriteLine(result);
    }
}