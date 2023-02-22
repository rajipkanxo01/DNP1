namespace LargestProductSeries;

public class Digits
{
    public static string GenerateRandomString()
    {
        string digits = "0123456789";
        Random random = new Random();
        char[] charArray = new char[10];

        for (int i = 0; i < 10; i++)
        {
            charArray[i] = digits[random.Next(digits.Length)];
        }

        return new string(charArray);
    }

    public static string FindProductOfDigits(int x)
    {
        string randomStrings = GenerateRandomString();
        int maxNumber = Int32.MinValue;
        Console.WriteLine(randomStrings);
        string maxElements = "";
        char[] currentNElements = new char[] { };

        for (int i = 0; i < randomStrings.Length; i += x)
        {
            currentNElements = randomStrings.Skip(i).Take(x).ToArray();
            Console.WriteLine(currentNElements);
            int product = 1;
            for (int j = 0; j < currentNElements.Length; j++)
            {
                product *= int.Parse(currentNElements[j].ToString());
                Console.WriteLine($"Element: {currentNElements[j]} \t Product: {product} ");
            }

            if (maxNumber <= product)
            {
                maxNumber = product;
                maxElements = new string(currentNElements);
            }
            // Console.WriteLine("Max number: " + maxNumber);
        }

        return maxElements;
    }
}