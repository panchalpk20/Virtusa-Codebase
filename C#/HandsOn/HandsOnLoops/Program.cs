using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnIterativeStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //while-loop
            //print name 10 times
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            int flag = 1;
            while (flag <= 10)
            {
                Console.WriteLine("Hello " + name);
                flag++;
            }
            Console.WriteLine("Enter no");
            int no = int.Parse(Console.ReadLine());
            int f = 1;
            while(f<=no)
            {
                Console.Write(f + "\t");
                f++;
            }
           Console.ReadKey();
        }
    }
}
