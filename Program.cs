using System;

namespace VsCodeLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y =7;
            Console.WriteLine(x+y);
            Console.WriteLine("Hello World!");
            Console.WriteLine("hello everyOne");

            const string Fname = "Hyacinthe";
            const string Lname = "Mutoni";
            Console.WriteLine(Fname + " "+ Lname);

            Console.WriteLine("Enter your name please!");
            string Mynames = Console.ReadLine();
            Console.Write(Mynames);

        }
    }
}
