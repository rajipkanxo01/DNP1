namespace DoctorsWaitingRoom;

public class WaitingRoom
{
    public Action<int> NumberChange { get; set; }
    private int currentNumber = 0;
    private int ticketCount = 0;

    public void RunWaitingRoom()
    {
        while (currentNumber < ticketCount)
        {
            Console.WriteLine("\n Diing!");
            NumberChange?.Invoke(currentNumber);
            currentNumber++;
            Console.WriteLine($"Patient number {currentNumber} can now enter");
            Thread.Sleep(1000);
        }
    }

    public int DrawNumber()
    {
        return ++ticketCount;
    }
}