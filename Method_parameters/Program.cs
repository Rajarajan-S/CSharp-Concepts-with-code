using System;

namespace Method_parameters
{
    class Program
    {
        // Value type parameter - Passing only the values
        public static void Method1(int a) 
        {
            a = 10;
        }
        
        // Reference type parameter - Passing the address of the value using 'ref' keyword
        public static void Method2(ref int b)
        {
            b = 10;
        }

        // Out parameter - used when we want a method to return more than one output. use 'out' keyword
        public static void Calculate(int x, int y, out int sum, out int product)
        {
            sum = x + y;
            product = x * y;
        }

        // Parameter array - used to pass arrays, lists and elements seperated by commas
        // One 'params' keyword should be used per method
        // Incase of various arguments, params keyword should be used last in method declaration
        public static void ParamsMethod(params int [] numbers)
        {
            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            // input for val & ref type
            int i = 0;
            Method1(i); // Prints 0
            Method2(ref i); // Prints 10
            Console.WriteLine(i);

            // input for out
            int sum, product = 0;
            Calculate(10,5, out sum, out product);
            Console.WriteLine("Sum: "+ sum+" Product: "+product);

            // input for params
            int[] numbers = new int[3] { 1, 2, 3 };
            ParamsMethod(numbers);

            Console.ReadLine();
        }
    }
}
