using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalReviewPart4
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowMenu();
        }

        //Question 1
        static void DoubleIt(ref int x)
        {
            x*=2;
        }

        //Question 2
        static void CubeIt(int x, ref int cube)
        {
            cube = x * x * x;
        }


        //Question 3
        static void CalculateTuitionFee(int numberOfCourses, double costPerCourse, ref double fees)
        {
            fees = numberOfCourses * costPerCourse + 15.25;
        }

        //Question 4
        static void CalculateSumandDiff(int num1, int num2, ref int sum, ref int diff)
        {
            sum = num1 + num2;
            diff = Math.Abs(num1 - num2);
        }

        //Question 5
        static void CalculateTrigValues(double degrees, out double sine, out double cosine, out double tangent)
        {
            double radians = degrees * Math.PI / 180;
            sine = Math.Sin(radians);
            cosine = Math.Cos(radians);
            tangent = Math.Tan(radians);
        }

        //Question 6
        static void CalculateSineCosine(double angle, ref double sine, ref double cosine)
        {
            double radians = angle * Math.PI / 180;
            sine = Math.Sin(angle);
            cosine = Math.Cos(angle);
        }

        //Question 7
        static void QuadraticFormula(double a, double b, double c, out double x1, out double x2)
        {
                x1 = (-b - Math.Pow(Math.Pow(b,2)-4*a*c,0.5))/ (2 * a);
                x2 = (-b + Math.Pow(Math.Pow(b, 2) - 4 * a * c, 0.5)) / (2 * a);
        }

        static void DisplayMenu()
        {
            Console.WriteLine("================ Part 4 Question 1-7 =================");
            Console.WriteLine("|       1. Double It                                 |");
            Console.WriteLine("|       2. Cube It                                   |");
            Console.WriteLine("|       3. Calculate Tuition Fee                     |");
            Console.WriteLine("|       4. Sum and Differernce                       |");
            Console.WriteLine("|       5. Calculate Trig Values                     |");
            Console.WriteLine("|       6. Sine and Cosine                           |");
            Console.WriteLine("|       7. Quadritic Formula                         |");
            Console.WriteLine("|       0. Exit Program                              |");
            Console.WriteLine("======================================================");
            Console.WriteLine("          Enter the number of your choice ->          ");
        }

        static void ShowMenu()
        {
            int option = 999;

            while (option != 0)
            {

                DisplayMenu();
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 0:
                        int num;
                        double fee;
                        int sum;
                        int diff;
                        break;
                    case 1:
                        num = 5;
                        DoubleIt(ref num);
                        Console.WriteLine($"Before method call: 5 After method call:{num}");
                        num = 7;
                        DoubleIt(ref num);
                        Console.WriteLine($"Before method call: 7 After method call:{num}");
                        continue;
                    case 2:
                        num = 0;
                        CubeIt(5, ref num);
                        Console.WriteLine($"Before method call: 5 After method call:{num}");
                        CubeIt(2, ref num);
                        Console.WriteLine($"Before method call: 2 After method call:{num}");
                        continue;
                    case 3:
                        fee = 0;
                        CalculateTuitionFee(5, 500, ref fee);
                        Console.WriteLine($"5 courses @$500.00 will cost a total of {fee:c}");
                        CalculateTuitionFee(5, 450, ref fee);
                        Console.WriteLine($"5 courses @$450.00 will cost a total of {fee:c}");
                        CalculateTuitionFee(10, 450, ref fee);
                        Console.WriteLine($"10 courses @$450.00 will cost a total of {fee:c}");
                        CalculateTuitionFee(10, 350, ref fee);
                        Console.WriteLine($"10 courses @$350.00 supplied will cost a total of {fee:c}");
                        continue;
                    case 4:
                        sum = 0;
                        diff = 0;
                        CalculateSumandDiff(10, 15, ref sum, ref diff);
                        Console.WriteLine($"a:10, b:15. sum:{sum}. diff:{diff}");
                        CalculateSumandDiff(25, 15, ref sum, ref diff);
                        Console.WriteLine($"a:25, b:15. sum:{sum}. diff:{diff}");
                        CalculateSumandDiff(25, 25, ref sum, ref diff);
                        Console.WriteLine($"a:25, b:25. sum:{sum}. diff:{diff}");
                        continue;
                    case 5:
                        double degrees = 0;
                        Console.WriteLine("  Angle     Sine     Cosine     Tangent");
                        for (int i=0; i<20; i++)
                        {
                            CalculateTrigValues(degrees, out double sine, out double cosine, out double tangent);
                            Console.WriteLine($"{degrees,7:g4}{sine,9:g4}{cosine,11:g4}{tangent,12:g4}");
                            degrees += 5;
                        }
                        continue;
                    case 6:
                        double angle = 0.5;
                        double sine2 = 0;
                        double cosine2 = 0;
                        Console.WriteLine("  Angle     Sine     Cosine");
                        for(int i = 0; i < 10;i++) { 
                            CalculateSineCosine(angle, ref sine2, ref cosine2);
                            Console.WriteLine($"{angle,7:f4}{sine2,9:f4}{cosine2,11:f4}");
                            angle += 0.01;
                        }
                        continue;
                    case 7:
                        QuadraticFormula(12, 1, -6, out double x1, out double x2);
                        Console.WriteLine($"The Equation 12x^2+1x+-6 will have roots {x1:f3} and {x2:f3}");
                        continue;
                    default:
                        continue;
                }

            }
        }
    }
}
