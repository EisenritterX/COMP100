using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 18.	Create a console-based lottery game application.
 * Generate three random numbers, each between 1 and 4. 
 * Allow the user to guess three numbers.
 * Compare each of the user’s guesses to the three random numbers and display a message that includes the user’s guess, the randomly determined three-digit number, and the amount of money the user has won as follows:
*Matching Numbers	Award ($)
*Any one matching	10
*Two matching	100
*Three matching, not in order	1,000
*Three matching in exact order	10,000
*No matches	0
*Make certain that your application accommodates repeating digits. For example, if a user guesses 1, 2, and 3, and the randomly generated digits are 1, 1, and 1, do not give the user credit for three correct guesses—just one.
*/
namespace Exercise_18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int nGuess1;
            int nGuess2;
            int nGuess3;
            //Output
            int rng1;
            int rng2;
            int rng3;
            int payout;
            Random randomGenerator = new Random();
            rng1 = randomGenerator.Next(1, 5);
            rng2 = randomGenerator.Next(1, 5);
            rng3 = randomGenerator.Next(1, 5);
            //Algorithm
            Console.Write("Pick the first number " );
            nGuess1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Pick the second number ");
            nGuess2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Pick the third number");
            nGuess3 = Convert.ToInt32(Console.ReadLine());

            if (nGuess1 == rng1 || nGuess1 == rng2 || nGuess1 == rng3)
            {
                payout = 10;
                if (nGuess2==rng2 || nGuess2 == rng3)
                {
                    payout = 100;
                    if (nGuess3 == rng3)
                    {
                        payout = 10000;
                    }
                }
                
            }
            else if (nGuess2 == rng1 || nGuess2 == rng2 || nGuess2 == rng3)
            {
                payout = 10;
                if (nGuess1 == rng2 || nGuess1 == rng3)
                {
                    payout = 100;
                    if (nGuess3 == rng3||nGuess3 == nGuess2)
                    { }
                }
            }
            else if (nGuess3 == rng1 || nGuess3 == rng2 || nGuess3 == rng3)
            {
                payout = 10;
            }
        }
    }
}
