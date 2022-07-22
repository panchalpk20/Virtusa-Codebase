using System;
namespace FirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Welcome to JPMS");
            Console.WriteLine("Pls Enter Name");
            string ?name = Console.ReadLine(); //reads value from input
            Console.WriteLine("Hello " + name);
            Console.WriteLine("Enter age");
            int ?age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello {0} your Age is {1}", name, age);
            Console.ReadKey(); //Read output
        }
    }
}