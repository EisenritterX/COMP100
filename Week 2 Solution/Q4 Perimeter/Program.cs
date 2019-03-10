using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double side1;
            double side2;
            double side3;
            double side4;
            //processing
            //output
            double perimeter;
            //Algorithm
            Console.Write("Side 1 Length is: ");
            side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Side 2 Length is: ");
            side2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Side 3 Length is: ");
            side3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Side 4 Length is: ");
            side4 = Convert.ToDouble(Console.ReadLine());
            perimeter = side1 + side2 + side3 + side4;
            Console.WriteLine("The perimeter of the polygon is {0}", perimeter);
            //string interpolation
            //must start with a dollar symbol
            //variable is encloase by a pair of braces
            Console.WriteLine($"The perimeter of the polygon is {perimeter}");
        }
    }
}
