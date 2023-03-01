namespace Breakfast;

public class Food
{
    public async static Task MakeAsynch()
    {
        // string cup = PourCoffee();
        Console.WriteLine("coffee is ready");
        Task<string> eggsTask = FryEggsAsync(2);
        Task<string> baconTask = FryBaconAsync(3);
        // Task<Toast> toastTask = ToastWithButterJamAsync(2);
        var eggs = await eggsTask;
        Console.WriteLine("eggs are ready");
        var bacon = await baconTask;
        Console.WriteLine("bacon is ready");
        Console.WriteLine("oj is ready");
        Console.WriteLine("Breakfast is ready!");
    }

    private static async Task<string> FryEggsAsync(int howMany)
    {
        Console.WriteLine("Warming the egg pan...");
        await Task.Delay(3000);
        Console.WriteLine($"cracking {howMany} eggs");
        Console.WriteLine("cooking the eggs ...");
        await Task.Delay(3000);
        Console.WriteLine("Put eggs on plate");
        return "egg";
    }

    private static async Task<string> FryBaconAsync(int slices)
    {
        Console.WriteLine($"putting {slices} slices of bacon in the pan");
        Console.WriteLine("cooking first side of bacon...");
        await Task.Delay(3000);
        for (int slice = 0; slice < slices; slice++)
        {
            Console.WriteLine("flipping a slice of bacon");
        }

        Console.WriteLine("cooking the second side of bacon...");
        await Task.Delay(3000);
        Console.WriteLine("Put bacon on plate");
        return "bacon";
    }
}