using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliverable_One
{
    class Program
    {
        static void Main(string[] args)
        {
            //Delcaration of Variables
            int x, y, num1, num2, num3, num4, num5, num6, num7, num8;

            //Read data from user
            Console.WriteLine("Enter any 4 digit number (x): ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another 4 digit number (y): ");
            y = int.Parse(Console.ReadLine());

            //dividing the input into individual integers

            num4 = (x / 1) % 10;
            num3 = (x / 10) % 10;
            num2 = (x / 100) % 10;
            num1 = (x / 1000) % 10;
            num8 = (y / 1) % 10;
            num7 = (y / 10) % 10;
            num6 = (y / 100) % 10;
            num5 = (y / 1000) % 10;

            int a = num4 += num8;
            int b = num3 += num7;
            int c = num2 += num6;
            int d = num1 += num5;



            // if/else loop to compare the two numbers

            if (a == b)
            {
                if (b == c)
                {
                    if (c == d)
                        Console.WriteLine("True");

                    else
                    { Console.WriteLine("False"); }
                }
                else
                { Console.WriteLine("False"); }
            }
            else
            { Console.WriteLine("False"); }

 Console.ReadKey();
        }
    }
}
