using System;

namespace EqualityOfVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 5;
            Console.WriteLine("Program to check parity of our variables");
            Console.WriteLine("a = 5");
            Console.WriteLine("b = 5");
            if (a == b)
            {
                Console.WriteLine("Variables a and b are equal");
            }
            else
            {
                Console.WriteLine("Variables a and b are not equal");
            }
        }
    }

}
