using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Write a program to ask the user about the validity of a simple statement. 
 * The program should accept the response then display the statement as well as the response. 
 * The response should be true or false. 
 * For this question, you must use a variable of type bool.
 */
namespace Question_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            bool answer;
            //Processing
            //Output
            //Algorithm
            Console.Write("Is the answer to the universe 42?(Enter true or false) ");
            answer = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine($"Is the answer to the universe 42? Your answer is {answer}");
        }
    }
}
