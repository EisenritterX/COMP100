using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *4.Write a console-based program that accepts a user’s message and 
 * determines whether it is short enough for a social networking service that does not accept messages of more than 140 characters. 
 * [Hint: if the user’s input is assigned to the variable message then message.Length with give the number of characters in the input]
 */
namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string msg;
            //Algorithm
            Console.Write("What is your message?");
            msg = Console.ReadLine();
            if (msg.Length > 140)
            {
                Console.WriteLine($"Your message is too long, please shorten it to under 140 characters!");
            }
        }
    }
}
