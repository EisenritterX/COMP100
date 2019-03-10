using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *17.Create a console-based game in which the computer randomly chooses rock, paper, or scissors. 
 * Let the user enter a character, ‘r’, ‘p’, or ‘s’, 
 * each representing one of the three choices. Then, determine the winner. 
 */
namespace Exercise_17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string p1Choice;
            string p2Choice;
            //Output
            //Algorithm
            Console.WriteLine("Rock, Paper, Scissors! What does Player 1 Choose (Please input r, p or s) ");
            p1Choice = Console.ReadLine();

            Random randomGenerator = new Random();
            int rng = randomGenerator.Next(1, 4);

            if (rng == 1)
            {
                p2Choice = "r";
                if (p1Choice == p2Choice)
                {
                    Console.WriteLine("It's a tie!");
                }
                else if (p1Choice == "p")
                {
                    Console.WriteLine("Player 2 Wins!");
                }
                else if (p1Choice == "s")
                {
                    Console.WriteLine("Player 2 Loses!");
                }
            }
            else if (rng == 2)
            {
                p2Choice = "p";
                if (p1Choice == p2Choice)
                {
                    Console.WriteLine("It's a tie!");
                }
                else if (p1Choice == "p")
                {
                    Console.WriteLine("Player 2 Wins!");
                }
                else if (p1Choice == "s")
                {
                    Console.WriteLine("Player 2 Loses!");
                }
            }
            else if (rng == 3)
            {
                p2Choice = "s";
                if (p1Choice == p2Choice)
                {
                    Console.WriteLine("It's a tie!");
                }
                else if (p1Choice == "p")
                {
                    Console.WriteLine("Player 2 Wins!");
                }
                else if (p1Choice == "s")
                {
                    Console.WriteLine("Player 2 Loses!");
                }
            }
        }
    }
}
