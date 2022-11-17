using System;

namespace do_while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = string.Empty;

            // do while loop checks the condition at the end of the loop
            // It executes atleast one time
            // Could be used as replacement of switch case statement.
            do
            {
                Console.WriteLine("\nEnter the number limit:");
                int l = int.Parse(Console.ReadLine());
                int start = 0;

                Console.WriteLine("\nPrinting even numbers within {0}\n", l);
                while (start <= l)
                {
                    Console.WriteLine(start);
                    start += 2;
                }
           
                do
                {
                    Console.WriteLine("\nDo you want to continue? Type Yes / No");
                    choice = Console.ReadLine().ToUpper();

                    if (choice != "YES" && choice != "NO")
                    {
                        Console.WriteLine("Enter valid choice. Yes / No");
                    }
                } while (choice != "YES" && choice != "NO");
            }while(choice == "YES");
            Console.ReadLine();
        }
    }
}
