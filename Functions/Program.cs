// Functions or Methods in C#
using System;

namespace Functions
{
   
    class Program
    {
        // access modifier - return type - method name - parameters
        public double Add(double a1, double b1)
        {
            return a1 + b1;
        }

        public double Sub(double a1, double b1)
        {
            return Math.Abs(a1 - b1);
        }

        public double Product(double a1, double b1)
        {
            return a1 * b1;
        }

        public double Divide(double a1, double b1)
        {
            return a1 / b1;
        }

        static void Main(string[] args)
        {
            Program calculator = new Program(); // instantiation of program class

            Console.WriteLine("Enter two numbers:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("\n");
            Console.WriteLine("The sum of {0} and {1} is " + calculator.Add(a, b),a,b);
            Console.WriteLine("The difference between {0} and {1} is " + calculator.Sub(a, b),a,b);
            Console.WriteLine("The product of {0} and {1} is "+ calculator.Product(a, b),a,b);
            Console.WriteLine("The division of {0} and {1} is "+ calculator.Divide(a, b),a,b);

            Console.ReadLine();
        }      
    }
}
