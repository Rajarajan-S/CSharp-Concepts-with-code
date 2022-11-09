//Namespace - Collection of classes, interfaces, enums etc., Here, 'Console' class in inside the 'System' namespace 
using System;

class Program // Class
{
    static void Main(string[] args)  //Main method - Entry point of your application
    {
        Console.WriteLine("Introduction to C#"); // Writes a line
        Console.WriteLine("\n");
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine(); // Reads a line/input and storing it in a datatype
        Console.WriteLine("\n");
        Console.WriteLine("Hai " + name); // Concatenation 
        Console.WriteLine("Hai {0}", name); // Using placeholder
        Console.ReadLine();
    }
}
 
 