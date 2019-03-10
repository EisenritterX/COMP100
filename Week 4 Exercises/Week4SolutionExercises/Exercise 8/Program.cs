using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*8.	Write a program that allows the user to enter two integers and a character 
 * If the character is A, add the two integers If it is S, subtract the second integer from the first 
 * if it is M, multiply the integers Display the results of the arithmetic
 */ 
namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int n1;
            int n2;
            string arith;
            //Processing
            //Output
            double result;
            //Algorithm
            Console.Write("What's your first number?");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("What's your first number?");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("What arithmatic operation do you want? (Enter A for addition, S for subtraction and M for multiplication)");
            arith = Console.ReadLine();
            //Processing
            if (arith == "A")
            {
                result = n1+n2;
                Console.WriteLine($"Your arithmatic operation is addition, which result to {result}.");
            }
            else if (arith == "S")
            {
                result = n1 - n2;
                Console.WriteLine($"Your arithmatic operation is subtraction, which result to {result}.");
            }
            else if (arith == "M")
            {
                result = n1 * n2;
                Console.WriteLine($"Your arithmatic operation is multiplication, which result to {result}.");
            }
        }
    }
}
