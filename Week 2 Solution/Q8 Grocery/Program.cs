using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Othello’s Grocery would like a program that will prompt the user for the weight and price of the produce, the price and capacity of plastic bag and then calculates and displays the total cost of the sale. You may assume that all customers will require bags. 
 * You may use the following sample inputs (price 11₵ per kg, weight 25kg and capacity of bag is 5 (one bag is able to hold 5 kg of produce), price of a plastic bag 5₵. The total cost is 300₵)
 */ 
namespace Q8_Grocery
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double pWeight;
            double pPrice;
            double bPrice;
            double bCap;
            //processing
            //output
            double total;
            //Algorithm
            Console.Write("What's the weight of the produce: ");
            pWeight = Convert.ToDouble(Console.ReadLine());
            Console.Write("What is the price of the produce: ");
            pPrice = Convert.ToDouble(Console.ReadLine());
            Console.Write("What is the price of the bag: ");
            bPrice = Convert.ToDouble(Console.ReadLine());
            Console.Write("What is the capacity of the bag: ");
            bCap = Convert.ToDouble(Console.ReadLine());
            total = pWeight*pPrice + pWeight/bCap*bPrice;
            Console.WriteLine($"Your total would be {total:C}");
        }
    }
}
