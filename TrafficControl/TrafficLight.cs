namespace TrafficControl;

public class TrafficLight
{
    public Action<string> OnLightChange { get; set; } = null!;
    private string[] colors = { "GREEN", "YELLOW", "RED" };

    public void RunTrafficLight()
    {
        for (int i = 0; i < 12; i++)
        {
            int idx = i % colors.Length;
            Console.WriteLine("\n Light is " + colors[idx]);
            OnLightChange?.Invoke(colors[idx]);
            Thread.Sleep(1000);
        }
    }
}