// See https://aka.ms/new-console-template for more information

using ArrayClumb;

ClumpCount clumpCount = new ();
int [] numbers = new int[] {2,2,2,2,2,2,2};
Console.WriteLine(clumpCount.CountClumps(numbers));