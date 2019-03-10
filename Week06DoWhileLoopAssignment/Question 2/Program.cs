using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*2.	To display the numbers 1 … 5 on separate lines
 */ 
namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            do
            {
                Console.WriteLine(counter);
                counter++;
            }
            while (counter < 6);
        }
    }
}
