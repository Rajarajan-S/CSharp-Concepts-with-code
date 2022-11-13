using System;

namespace Switch_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int cost = 0;
            Console.WriteLine("Enter the size of pizza (inches): 6 / 8 / 10");
            int mark = int.Parse(Console.ReadLine());

            switch (mark)  // switch (parameter u need to evaluate)
            {
                case 6: 
                    cost += 200;
                    break;  // If the choice matches this case. The code will escape the switch block.
                case 8:
                    cost += 275;
                    break;
                case 10:
                    cost += 350;
                    break;
                default:
                    Console.WriteLine("\nYour choice is invalid !!! Enter only 6 / 8 / 10 ");
                    break; 
            }
            Console.WriteLine("\nYour bill amount is {0}", cost);
            Console.ReadLine();
        }
    }
}
