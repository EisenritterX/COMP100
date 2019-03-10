using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 8.	Same as the previous question but additionally displays the average of the numbers when the loop terminates. You will need a counter but not as a loop terminator.
 */
namespace Question_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int counter = 0;
            do
            {
                Console.WriteLine("What number do you want to add?");
                int number = Convert.ToInt32(Console.ReadLine());
                sum += number;
                counter++;
            }
            while (sum <= 100);
            Console.WriteLine(sum);
            Console.WriteLine(sum/counter);
        }
    }
}
