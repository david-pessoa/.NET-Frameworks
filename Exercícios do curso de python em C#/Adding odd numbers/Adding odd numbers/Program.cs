// See https://aka.ms/new-console-template for more information
List<int> odds = new List<int>();
for(int i = 1; i < 100; i += 2)
{
    odds.Add(i);
}
Console.WriteLine(odds.Sum());
