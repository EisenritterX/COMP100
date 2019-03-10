using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 7.	To repeatedly prompt for a number and sum it. 
 * When the sum just exceeds 100, stop the prompting and display the sum at the end.
 * You must not display the sum while the user in typing in numbers. 
 * (You do not need a counter but you will need some way of terminating the loop)
 */
namespace Question_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum=0;
            do
            {
                Console.WriteLine("What number do you want to add?");
                int number = Convert.ToInt32(Console.ReadLine());
                sum += number;
            }
            while (sum <= 100);
            Console.WriteLine(sum);
        }
    }
}
