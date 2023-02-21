namespace MathLib.Calculator;

public class Calculator
{
    public int Add(int x, int y)
    {
        return x + y;
    }

    public int Add(int[] numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum;
    }
}