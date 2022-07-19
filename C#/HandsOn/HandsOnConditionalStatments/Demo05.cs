using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConditionalStatements
{
    class Demo05
    {
        static void Main()
        {
            Console.WriteLine("Enter the Day");
            string name = Console.ReadLine();
            name = name.ToUpper(); //convert to uppercase
            switch(name)
            {
                case "MONDAY":
                case "TUESDAY":
                case "FRIDAY":
                    Console.WriteLine("It is a Weekday");
                    break;
                case "SATDAY":
                case "SUNDAY":
                    Console.WriteLine("It is a weekEnd");
                    break;
                default:
                    Console.WriteLine("Invalid day");
                    break;
            }
            Console.ReadKey();
        }
    }
}
