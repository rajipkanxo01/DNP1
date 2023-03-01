namespace Palindrome;

public class PalindromeChecker
{
    public bool CheckPalindrome(string s)
    {
        char[] stringArray = s.Replace(" ", "").ToCharArray();
        char[] reverseArray = stringArray.Reverse().ToArray();
        Boolean value = true;

        if (stringArray.Length == reverseArray.Length)
        {
            for (int i = 0; i < stringArray.Length; i++)
            {
                if (stringArray[i] != reverseArray[i])
                {
                    value = false;
                    break;
                }
            }
        }
        else
        {
            value = false;
        }

        return value;
    }
}