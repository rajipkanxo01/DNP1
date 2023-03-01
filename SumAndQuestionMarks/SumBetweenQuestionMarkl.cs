using System.Text.RegularExpressions;

namespace SumAndQuestionMarks;

public class SumBetweenQuestionMark
{
    public static string GenerateRandomString()
    {
        string characters = "abcdefghijklmnopqrstuvwxyz0123456789????";
        Random random = new Random();
        char[] charArray = new char[20];

        for (int i = 0; i < 20; i++)
        {
            charArray[i] = characters[random.Next(characters.Length)];
        }

        return new string(charArray);
    }

    public static void FindSum(string s)
    {
        List<int> sumArray = new List<int>();
        if (!s.Contains("?"))
        {
            Console.WriteLine("? not found in given string.");
        }

        string[] subStrings = s.Split("?");

        foreach (string t in subStrings)
        {
            int sum = 0;
            for (int j = 0; j < t.Length; j++)
            {
                if (char.IsDigit(t[j]))
                {
                    int s1 = int.Parse(t[j].ToString());
                    sum += s1 ;
                }
            }
            sumArray.Add(sum);
        }
        
        sumArray.ForEach(Console.WriteLine);
        
    }
}