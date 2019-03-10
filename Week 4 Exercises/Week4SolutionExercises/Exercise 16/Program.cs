using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 16.	In the game Rock Paper Scissors, two players simultaneously choose one of three options: rock, paper, or scissors. 
 * If both players choose the same option, then the result is a tie. 
 * However, if they choose differently, the winner is determined as follows:
 * Rock beats scissors, because a rock can break a pair of scissors.
 * Scissors beats paper, because scissors can cut paper.
 * Paper beats rock, because a piece of paper can cover a rock.
 */
namespace Exercise_16
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
            Console.WriteLine("Rock, Paper, Scissors! What does Player 1 Choose");
            p1Choice = Console.ReadLine();
            Console.WriteLine("Rock, Paper, Scissors! What does Player 2 Choose");
            p2Choice = Console.ReadLine();

            if (p1Choice == p2Choice)
            {
                Console.WriteLine("It's a tie!");
            }
            else if (p1Choice == "rock")
            {
                if (p2Choice == "scissors")
                {
                    Console.WriteLine("Player 1 Wins!");
                }
                else if (p2Choice == "paper")
                    Console.WriteLine("Player 2 Wins!");
            }
            else if (p1Choice == "scissors")
            {
                if (p2Choice == "paper")
                {
                    Console.WriteLine("Player 1 Wins!");
                }
                else if (p2Choice == "rock")
                    Console.WriteLine("Player 2 Wins!");
            }
            else if (p1Choice == "paper")
            {
                if (p2Choice == "rock")
                {
                    Console.WriteLine("Player 1 Wins!");
                }
                else if (p2Choice == "scissors")
                    Console.WriteLine("Player 2 Wins!");
            }
        }
    }
}
