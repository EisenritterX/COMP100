using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*7.The average cost of a college textbook is $125. 
 * There is a premium of 20% on hardcover text and a discount of 5% on sales of more than 4 textbooks. 
 * Write a program to prompt the user for the appropriate inputs and compute and display the before-tax cost of the textbooks.
*Sample calculation: 
*price of 10 hardcover text = 10 * 125 + premium –discount
*price = 1250 + 20% of 1250 – 5% of 1250
*price = $1437.50
*
*price of 8 softcover text = 8 * 125 –discount
*price = 1000  – 5% of 1000
*price = $950
*
*price of 2 softcover text = 2 * 125
*price = $250
*/
namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            double nHC;
            double nSC;
            //Processing
            double nBooks;
            //Output
            double total;
            //Algorithm
            Console.Write("How many hardcovers bought?");
            nHC = Convert.ToDouble(Console.ReadLine());
            Console.Write("How many softcovers bought?");
            nSC = Convert.ToDouble(Console.ReadLine());
            //Processing
            nBooks = nHC + nSC;
            total = nHC * 125 * 1.20 + nSC * 125;
            if (nBooks > 4)
            {
                total = total * 0.95;
                Console.WriteLine($"You qualify for premiums, the total price is {total}.");
            }
            else if (nBooks <= 4)
            {
                Console.WriteLine($"You don't qualify for premiums, the total price is {total}.");
            }
        }
    }
}
