namespace ArrayClumb;

public class ClumpCount
{
    public int CountClumps(int[] numbers)
    {
        bool insideClump = false;
        int clumps = 0;
        int currentNumber = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (currentNumber == numbers[i])
            {
                insideClump = true;
                currentNumber = numbers[i];
            }
            else
            {
                if (insideClump)
                {
                    clumps++;
                }

                insideClump = false;
                currentNumber = numbers[i];
            }
        }

        if (insideClump)
        {
            clumps++;
        }

        return clumps;
    }
}