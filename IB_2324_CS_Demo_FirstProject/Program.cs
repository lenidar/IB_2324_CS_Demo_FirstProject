using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IB_2324_CS_Demo_FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        { // <-- start
            // Initialization Step
            //  variable declarations
            int a = 1;
            int b = 2;
            int c = 0;
            bool isEven = false;
            string uInput = "";

            // Logic Steps            
            //  Inputs are here
            //  Conditions are here
            //  processes are here
            Console.Write("Please input the first number: ");
            uInput = Console.ReadLine(); 
            // readline will read all character inputs until
            // the user presses enter
            a = int.Parse(uInput);
            // parse will attempt to conver the string value into
            // an integer

            Console.Write("Please input the second number: ");
            uInput = Console.ReadLine();
            b = int.Parse(uInput);

            c = a + b;

            if(c % 2 == 0)
            {
                isEven = true;
            }


            // Output Steps
            //  final output of the logic
            Console.Write("The sum of ");
            Console.Write(a);
            Console.Write(" and ");
            Console.Write(b);
            Console.Write(" is ");
            Console.WriteLine(c);

            // Concatination
            Console.WriteLine("The sum of " + a + " and "
                + b + " is " + c);

            // string builder 1
            Console.WriteLine("The sum of {0} and {1} is {2}"
                , a, b, c);

            // string builder 2
            Console.WriteLine($"The sum of {a} and {b} is {c}");

            if(isEven) 
            {
                Console.WriteLine($"{c} is Even");
            }
            else
            {
                Console.WriteLine($"{c} is Odd");
            }


            Console.ReadKey();

        } // <-- end
    }
}
