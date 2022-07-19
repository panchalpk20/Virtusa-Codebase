using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTypeConversion
{
    internal class Demo0
    {
        static void Main()
        {
            //Reading va value from console input 
            Console.WriteLine("Enter your Name");
            string name=Console.ReadLine(); //Reads a value from input
            //Console.WriteLine("Hello {0}",name);
            Console.WriteLine("Enter Age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Gender");
            char gender=Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter your weight");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine($"Name:{name}\n Age:{age}\n Gender:{gender}\n Weight:{d}");
            Console.ReadKey();
        }
    }
}
