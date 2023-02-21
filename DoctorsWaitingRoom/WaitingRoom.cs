namespace DoctorsWaitingRoom;

public class WaitingRoom
{
    public Action<int> NumberChange { get; set; }
    private int currentNumber = 0;
    private int ticketCount = 0;
    
    
}