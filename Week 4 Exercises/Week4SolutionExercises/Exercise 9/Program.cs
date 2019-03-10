using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*9.	Write a console-based application that asks a user to enter an IQ score.
 * If the score is a number less than 0 or greater than 200, issue an error message; 
 * otherwise, issue an “above average”, “average”, or “below average” message for scores over, at, or under 100, respectively.
 */ 
namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int IQ;
            //Algorithm
            Console.Write("What is your IQ?");
            IQ = Convert.ToInt32(Console.ReadLine());
            if (IQ < 0 || IQ > 200)
            {
                Console.WriteLine($"Don't try to cheat the system, I'm watching you");
            }
            else if (IQ >= 0 && IQ < 100)
            {
                Console.WriteLine($"Your IQ is below average");
            }
            else if (IQ > 100 && IQ <= 200)
            {
                Console.WriteLine($"Your IQ is above average");
            }
            else if (IQ && 100)
            {
                Console.WriteLine($"Your IQ is average");
            }

        }
    }
}
