namespace DoctorsWaitingRoom;

public class Patient
{
    private int numberInQueue;
    private WaitingRoom waitingRoom;

    public Patient(WaitingRoom waitingRoom)
    {
        this.waitingRoom = waitingRoom;
        waitingRoom.NumberChange += ReactToNumber;
        numberInQueue = waitingRoom.DrawNumber();
    }

    private void ReactToNumber(int number)
    {
        Console.WriteLine($"Patient {numberInQueue} looks up");
        if (numberInQueue == number)
        {
            Console.WriteLine($"Patient {numberInQueue} goes to the doctor's office");
        }
        else
        {
            Console.WriteLine($"Patient {numberInQueue} goes back to play with phone.");
        }
    }
}