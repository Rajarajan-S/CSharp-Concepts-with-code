using System;

namespace CSharp_StringType
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "\"Github\"";  // Escape sequence - use \ before " if you want to print a " in output
            Console.WriteLine(name);
            string path = @"C:\Users\91737\Documents";  // Verbatim literal - Use @ before "to-be-printed" to print the sentence with escape sequence charaters
            Console.WriteLine(path);

            Console.ReadLine();
        }
    }
}
