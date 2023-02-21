// See https://aka.ms/new-console-template for more information

using Substring;

FirstLastCharacters characters = new();
Console.WriteLine("Enter a word:");
string word = Console.ReadLine();
Console.WriteLine("Enter how many number of characters you want:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(characters.NTwice(word, number));