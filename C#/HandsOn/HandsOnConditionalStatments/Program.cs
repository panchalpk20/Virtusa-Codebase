using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string s = Console.ReadLine();
            //simple if
            if(s=="Sachin")
            {
                Console.WriteLine("Hello " + s);
            }
        }
    }
}
