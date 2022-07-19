using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnIterativeStatements
{
    class Demo2
    {
        static void Main()
        {
            Console.WriteLine("Enter a no");
            int no = int.Parse(Console.ReadLine());
            int f = 1;
            do
            {
                Console.Write(f+"\t");
                f++;
            } while (f <= no);
        }
    }
}
