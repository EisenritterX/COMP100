using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Tile Limited wants a program allows its salesclerk to enter the length and width (in meters) of a rectangle and the price of a square meter of tile.
 * The program should display the area of the rectangle and the total cost of the tile.
 */
namespace Q7_Tile
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double length;
            double width;
            double price;
            //processing
            //output
            double area;
            double total;
            //Algorithm
            Console.Write("What's the length of the rectangle: ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.Write("What is the width of the rectangle: ");
            width = Convert.ToDouble(Console.ReadLine());
            Console.Write("What is the price per square meter of the tile: ");
            price = Convert.ToDouble(Console.ReadLine());
            area = length*width;
            total = area * price;
            Console.WriteLine($"The area of the rectangle is {area}, and the the total cost to fill the rectangle would be {total:C}");
        }
    }
}
