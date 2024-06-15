using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your height in meters: ");
            float height = float.Parse(Console.ReadLine());
            Console.Write("Enter your weight in kg: ");
            float weight = float.Parse(Console.ReadLine());
            float bmi = weight / (height * height);

            if (bmi < 18.5)
            {
                Console.WriteLine("Your bmi is " + bmi + ", you are underweight.");
            }
            else if (bmi < 25)
            {
                Console.WriteLine("Your bmi is " + bmi + ", you have a normal weight.");
            }

            else if (bmi < 30)
            {
                Console.WriteLine("Your bmi is " + bmi + ", you are overweight.");
            }

            else if (bmi < 35)
            {
                Console.WriteLine("Your bmi is " + bmi + ", you are obese.");
            }
            else
            {
                Console.WriteLine("Your bmi is " + bmi + ", you are very obese.");
            }


        }
    }
}
