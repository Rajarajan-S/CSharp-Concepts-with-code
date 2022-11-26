using System;

namespace Classes
{
    class Student    // A class named 'Student'
    {
        // Fields of class - name, rollno
        string name;    
        string rollno;

        // Class constructor
        // initialize class fields
        // automatically called when an instance of class is created
        // doesn't have return values
        // constructors are not mandatory. If there is no costructor, default is always provided
        public Student(string Name, string Rollno) 
        {
            this.name = Name;
            this.rollno = Rollno;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Name: {0}, Roll number: {1}", this.name,this.rollno);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Jack","18AE001");
            Student s2 = new Student("Robert","18AE002");
            //Student s3 = new Student(Console.ReadLine(), Console.ReadLine());

            s1.PrintInfo();
            s2.PrintInfo();
            //s3.PrintInfo();

            Console.ReadLine();
        }
    }
}
