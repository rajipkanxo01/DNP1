namespace KthLargestNumber;

public class LargestNumber
{
    public int FindLargestNumber(int[] numbers, int k)
    {
        // Array.Sort(numbers);
        if (numbers.Length < k)
        {
            throw new Exception("k is larger than the length of the array");
        }

        int number = numbers.OrderDescending().ToArray()[k-1];
        return number;
    }
}