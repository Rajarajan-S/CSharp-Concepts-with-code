// There are 2 types of datatype in C#
// Value types - int, float, double, bool etc.,
// Reference type - array, delegate, event, 

using System;

namespace Nullable_types
{
    class Program
    {
        static void Main(string[] args)
        {
            // Converting not nullable type to nullable type
            //int a = null; - int is not a nullable datatype
            int? b = null; // by addding ? after int, we can make it nullable 

            if (b == null)
            {
                Console.WriteLine("b is null");
            }

            bool? AreYouStudent = null;
            
            if (AreYouStudent == null)
            {
                Console.WriteLine("User didn't answer");
            }

            // Null coalescing operator
            int? SeatsSold = null;
            int SeatsLeft =  SeatsSold ?? 0; 
            // It sets SeatsLeft as 0 if the SeatsSold is null / Keep the value if it is not null

            Console.WriteLine("Seats left is {0}", SeatsLeft);

            Console.ReadLine();
        }
    }
}
