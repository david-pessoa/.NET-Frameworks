// See https://aka.ms/new-console-template for more information
var rand = new Random();
List<int> scores = new List<int>();
for (int i = 0; i < 7; i++)
{
    scores.Add(rand.Next(0, 11));
}
Console.WriteLine(string.Join(", ", scores));
Console.WriteLine(scores.Min());