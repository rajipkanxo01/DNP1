namespace PrintingNumbers;

public class Numbers
{
    public void EvenNumber(int x)
    {
        Console.WriteLine("\nEven numbers: \n");

        for (int i = 0; i < x; i = i + 2)
        {
            Console.WriteLine(i);
        }
    }

    public void OddNumber(int x)
    {
        Console.WriteLine("\n Odd numbers: \n");
        for (int i = 1; i < x; i = i + 2)
        {
            Console.WriteLine(i);
        }
    }

    public void DivisibleBy(int x, int y)
    {
        Console.WriteLine($"\n Divisible By {y}: \n");
        for (int i = 0; i < x; i++)
        {
            if (i % y == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}