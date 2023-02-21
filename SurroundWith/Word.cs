namespace SurroundWith;

public class Word
{
    // substring: substring(0,2) -> selects 2 characters from string from 0 index
    public string MakeOut(string word, string outer)
    {
        return outer.Substring(0, 2) + word + outer.Substring(2);
    }
}