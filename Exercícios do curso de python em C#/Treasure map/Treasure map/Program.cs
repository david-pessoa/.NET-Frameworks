// See https://aka.ms/new-console-template for more information
string[,] map = new string[3, 3] { { "⬜️", "⬜️", "⬜️" }, { "⬜️", "⬜️", "⬜️" }, { "⬜️", "⬜️", "⬜️" } };

for(int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(map[i,j] + " ");
    }
    Console.Write("\n");
}
Console.WriteLine();
Console.Write("Give a coordinate: ");
string coordinate = Console.ReadLine();
int x = int.Parse(Convert.ToString(coordinate[0]));
int y = int.Parse(Convert.ToString(coordinate[1]));
map[x - 1, y - 1] = "X";
Console.WriteLine();
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(map[i, j] + " ");
    }
    Console.Write("\n");
}

