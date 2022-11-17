using System;

namespace While_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number limit:");
            int l = int.Parse(Console.ReadLine());
            int start = 0;

            Console.WriteLine("\nPrinting even numbers within {0}\n", l);

            // while loop checks the condition first. 
            // If the condition is true, it executes the code until the condition is valid.
            while (start <= l)
            {
                Console.WriteLine(start);
                start += 2;
            }
            Console.ReadLine();
        }
    }
}
