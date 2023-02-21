namespace Substring;

public class FirstLastCharacters
{
    public string NTwice(string word, int number)
    {
        return word.Substring(0, number) + word.Substring(word.Length - number, number);
    }
}