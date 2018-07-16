using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runProgram = true;
            while (runProgram) 
            {
                double length;
                double width;
                string input;

                Console.WriteLine("Enter length");
                length = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Width");
                width = double.Parse(Console.ReadLine());

                Console.Write("Perimeter:");

                Console.WriteLine((length * 2) + (width * 2));

                Console.Write("Area:");
                Console.WriteLine(length * width);

                Console.WriteLine("Continue? (Y/N)");
                input = Console.ReadLine();
                


                if (String.Equals(input, "Y", StringComparison.CurrentCultureIgnoreCase))
                { runProgram = true; }
                else
                { runProgram = false; }
            }


        }
    }
}
