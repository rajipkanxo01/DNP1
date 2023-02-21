namespace BiggestDifference;

public class Numbers
{
    public int BigDiff(int[] numbers)
    {
        int max = numbers.Max();
        int min = numbers.Min();
        return max - min;
    }
}