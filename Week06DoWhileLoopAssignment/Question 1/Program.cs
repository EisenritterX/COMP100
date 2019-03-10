using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 1.	To display five asterisks on a single line.Each asterisk must be separated by a space.You must use a do-while loop to solve this program
 */
namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            do
            {
                Console.Write("* ");
                counter++;
            }
             while (counter < 5);
        }
    }
}
