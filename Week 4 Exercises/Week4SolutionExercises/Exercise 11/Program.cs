using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*11.Write a console-based program for a college’s admissions office. 
 * The user enters a numeric high school grade point average (for example, 3.2) and an admission test score. 
 * Display the message “Accept” if the student meets either of the following requirements:
 * A grade point average of 3.0 or higher and an admission test score of at least 60
 * A grade point average of less than 3.0 and an admission test score of at least 80
 * If the student does not meet either of the qualification criteria, display “Reject”. 
*/
namespace Exercise_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            double GPA;
            double ats;
            //Algorithm
            Console.Write("What is your GPA?");
            GPA = Convert.ToDouble(Console.ReadLine());
            Console.Write("What is your adimission test score?");
            ats = Convert.ToDouble(Console.ReadLine());
            if (GPA >= 3.0 && ats >= 60)
            {
                Console.WriteLine("Accept");
            }
            else if (ats >= 80)
            {
                Console.WriteLine("Accept");
            }
        }
    }
}
