using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*13.To the Lawn application you created in the above question, 
 * add a prompt that asks the user whether the customer wants to pay (1) once, (2) twice, or (3) 20 times per season. 
 * If the user enters 1 for once, the fee for the season is simply the seasonal total. 
 * If the customer requests two payments, each payment is half the seasonal fee plus a $5 service charge. 
 * If the user requests 20 separate payments, add a $3 service charge per week. 
 * Display the number of payments the customer must make, each payment amount, and the total for the season.
 */ 
namespace Exercise_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            double length;
            double width;
            int options;
            //Output
            double total;
            double payment;
            //Algorithm
            Console.Write("What is the length of the lawn?");
            length = Convert.ToDouble(Console.ReadLine());
            Console.Write("What is the width of the lawn?");
            width = Convert.ToDouble(Console.ReadLine());
            if (length * width < 400)
            {
                total = 20 * 25;
                Console.WriteLine($"The weekly mowing fee is $25.00. Total fee for a 20-week season is {total:C}");
                Console.Write("What's your payment plan?(1) once, (2) twice, or (3)20 times per season");
                options = Convert.ToInt32(Console.ReadLine());
                if (options == 1)
                {
                    payment = total;
                    Console.WriteLine($"You are required to make one payment of {payment:C}. Total fee for a 20-week season is {total:C}");
                }
                if (options == 2)
                {
                    payment = total / 2 + 5;
                    total = payment * 2;
                    Console.WriteLine($"You are required to make two payment of {payment:C}. Total fee for a 20-week season is {total:C}");
                }
                if (options == 3)
                {
                    payment = total / 20 + 3;
                    total = payment * 20;
                    Console.WriteLine($"You are required to make twenty payment of {payment:C}. Total fee for a 20-week season is {total:C}");
                }
            }
            else if (length*width >= 400 && length * width <= 600)
            {
                total = 20*35;
                Console.WriteLine($"The weekly mowing fee is $35.00. Total fee for a 20-week season is {total:C}");
                Console.Write("What's your payment plan?(1) once, (2) twice, or (3)20 times per season");
                options = Convert.ToInt32(Console.ReadLine());
                if (options == 1)
                {
                    payment = total;
                    Console.WriteLine($"You are required to make one payment of {payment:C}. Total fee for a 20-week season is {total:C}");
                }
                if (options == 2)
                {
                    payment = total / 2 + 5;
                    total = payment * 2;
                    Console.WriteLine($"You are required to make two payment of {payment:C}. Total fee for a 20-week season is {total:C}");
                }
                if (options == 3)
                {
                    payment = total / 20 + 3;
                    total = payment * 20;
                    Console.WriteLine($"You are required to make twenty payment of {payment:C}. Total fee for a 20-week season is {total:C}");
                }
            }
            else if (length * width >= 600 )
            {
                total = 20*50;
                Console.WriteLine($"The weekly mowing fee is $50.00. Total fee for a 20-week season is {total:C}");
                Console.Write("What's your payment plan?(1) once, (2) twice, or (3)20 times per season");
                options = Convert.ToInt32(Console.ReadLine());
                if (options == 1)
                {
                    payment = total;
                    Console.WriteLine($"You are required to make one payment of {payment:C}. Total fee for a 20-week season is {total:C}");
                }
                if (options == 2)
                {
                    payment = total / 2 + 5;
                    total = payment * 2;
                    Console.WriteLine($"You are required to make two payment of {payment:C}. Total fee for a 20-week season is {total:C}");
                }
                if (options == 3)
                {
                    payment = total / 20 + 3;
                    total = payment * 20;
                    Console.WriteLine($"You are required to make twenty payment of {payment:C}. Total fee for a 20-week season is {total:C}");
                }
            }
            


        }
    }
}
