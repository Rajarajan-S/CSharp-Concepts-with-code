using System;

namespace for_foreach_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5] { 10, 11, 12, 13, 14 };

            // while loop
            // In while loop, we do initialization at one place and checks condition at another place
            int i = 0; // Iterator initilalization
            Console.WriteLine("Using while loop");
            while (i < numbers.Length) // checking condition
            {
                Console.WriteLine(numbers[i]);
                i++;
            }

            // for loop
            // In for loop, both initialization and condition checking happens at same statement
            Console.WriteLine("\nUsing for loop");
            for (int j=0; j < numbers.Length; j++)
            {
                Console.WriteLine(numbers[j]);
            }

            // foreach loop
            // foreach loop is used to iterate over the elements of the collection (array / list)
            // It executes for each element present in the collection
            Console.WriteLine("\nUsing foreach loop");
            foreach (int k in numbers)
            {
                Console.WriteLine(k);
            }
            Console.ReadLine();
        }      
    }
}
