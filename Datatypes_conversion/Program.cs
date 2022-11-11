using System;

namespace Datatypes_conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            float b = a; // Implicit conversion
            // float >> int. So, there is no loss of data while conversion of int to float
            Console.WriteLine("Value of b is {0}", b);

            // Explicit conversion
            // int << float.So, there is  loss of data while conversion of float to int
            float c = 15.455F;
            //Using Typecast 
            int d = (int)c;
            //Using Convert class
            int e = Convert.ToInt32(c);

            Console.WriteLine("Value of d using typecast is {0}", d);
            Console.WriteLine("Value of d using Convert class is {0}", e);

            // String to int conversion
            int res;
            string num = "123F";

            // Parse method
            int op = int.Parse(num);
            Console.WriteLine("Result using parse is {0}", op);

            // Tryparse method
            int.TryParse(num, out res);
            Console.WriteLine("Result using tryparse is {0}", res);
        }
    }
}
