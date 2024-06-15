using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_Height
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            double[] heights = new double[7];
            for (int i = 0; i < 7; i++)
            {
                double size = rand.Next(150, 201) / 100.0;
                heights[i] = size;
            }
            int lenght = heights.Count();
            double sum = heights.Sum();
            double average = sum / lenght;
            Console.WriteLine("The average is: " + average.ToString("F"));

        }
    }
}
