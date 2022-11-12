// Array - Collection of similar datatypes. Size of an array is fixed.
using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array declaration
            // Datatype arrayname = new datatype[size] {element 1,....element n}
            int[] array = new int[3] { 1, 2, 3 };

            // Printing an element at specific index
            Console.WriteLine("First element of array is " + array[0]);
            Console.WriteLine("Second element of array is " + array[1]);
            Console.WriteLine("\n");
            // Printing all elements of the array
            Console.WriteLine("The array elements are:");
            for (int i=0; i<array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadLine();
        }
    }
}
