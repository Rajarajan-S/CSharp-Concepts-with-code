using System;

namespace Switch_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int cost = 0;

        start: // label
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
                    goto start; 
            }

        here:
            Console.WriteLine("Do you want to buy another pizza? Enter YES or NO");
            string dec = Console.ReadLine();

            switch (dec.ToUpper())
            {
                case "YES":
                    goto start; // 'goto' makes a jump to specified label. Denoting a label named 'start'.

                case "NO":
                    break;

                default:
                    Console.WriteLine("\nYour choice is invalid !!! Enter only YES / NO ");
                    goto here;

            }
            Console.WriteLine("\nYour bill amount is {0}", cost);
            Console.ReadLine();
        }
    }
}
