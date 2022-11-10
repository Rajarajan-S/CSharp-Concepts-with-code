using System;

namespace Ternary_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 5;

            bool Isnum5 = num == 10 ? true : false;  
          //Datatype variable = if Condition (num==10 ?) returns true : else false

            Console.WriteLine("Number = 5 is {0}",Isnum5);

            Console.ReadLine();
        }
    }
}
