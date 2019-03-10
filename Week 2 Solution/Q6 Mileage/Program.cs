using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * When Jacob Steinberg began his trip to California, 
 * he filled his car’s tank with gas and reset his trip meter to zero. 
 * After traveling some distance (324 miles), Jacob stopped at a gas station to refuel; 
 * the gas tank required fuel (17 gallon). 
 * Create a program that Jacob can use to display his car gas mileage – the number of miles his can be driven per gallon of gas. 
 */
namespace Q6_Mileage
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double tankCap;
            double distance;
            //processing
            //output
            double mileage;
            //Algorithm
            Console.Write("How much distance driven: ");
            distance = Convert.ToDouble(Console.ReadLine());
            Console.Write("What is the capacity of the gas tank ");
            tankCap = Convert.ToDouble(Console.ReadLine());
            mileage = distance / tankCap;
            Console.WriteLine("Your mileage is {0}", mileage);
        }
    }
}
