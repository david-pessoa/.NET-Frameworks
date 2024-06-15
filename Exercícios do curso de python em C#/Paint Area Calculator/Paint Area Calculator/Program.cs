//1 can of paint can cover 5 square meters
int height;
int width;
double coverage = 5.0;

Paint_Area_Calculator.Outro calcula = new Paint_Area_Calculator.Outro();

Console.Write("Height of the wall: ");
height = int.Parse(Console.ReadLine());
Console.Write("Width of the wall: ");
width = int.Parse(Console.ReadLine());
calcula.calc_cans(height, width, coverage);

