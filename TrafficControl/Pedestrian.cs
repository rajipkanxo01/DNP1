namespace TrafficControl;

public class Pedestrian
{
    public int id;

    public Pedestrian(TrafficLight trafficLight, int id)
    {
        this.id = id;
        trafficLight.OnLightChange += ReactToLight;
    }

    private void ReactToLight(string color)
    {
        string result = $"Pedestrian {id}";
        switch (color)
        {
            case "GREEN":
                result += " waits for the car";
                break;
            case "YELLOW":
                result += " prepares to run";
                break;
            case "RED":
                result += " crosses the road";
                break;
        }

        Console.WriteLine(result);
    }
}