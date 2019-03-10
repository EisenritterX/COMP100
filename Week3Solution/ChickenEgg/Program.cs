using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Write a program that declares four variables to hold the number of eggs produced in a month by each of four hens.
 * Your program should sum the eggs, and then display the total in dozens. 
 * For example, a total of 127 eggs is 10 dozens and 7 eggs.
 */
namespace ChickenEgg
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int nEgg1;
            int nEgg2;
            int nEgg3;
            int nEgg4;
            //Processing
            int sum;
            //Output
            int dozen;
            int remainder;
            //Algorithm
            Console.Write("How many eggs hen 1 produced? ");
            nEgg1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many eggs hen 2 produced? ");
            nEgg2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many eggs hen 3 produced? ");
            nEgg3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many eggs hen 4 produced? ");
            nEgg4 = Convert.ToInt32(Console.ReadLine());
            sum = nEgg1 + nEgg2 + nEgg3 + nEgg4;
            dozen = (sum) / 12;
            remainder = sum % 12;
            Console.WriteLine($"There's a total of {sum} eggs. {dozen} dozens and {remainder} eggs.");
                    }
    }
}
