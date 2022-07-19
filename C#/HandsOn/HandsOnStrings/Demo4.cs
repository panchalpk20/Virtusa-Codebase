using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnStrings
{
    class Demo4
    {
        static void Main()
        {
            Console.WriteLine("Enter String");
            string s1 = Console.ReadLine();
            string s2 = String.Empty;
            for(int i=s1.Length-1;i>=0;i--)
            {
                s2 += s1[i];
            }
            Console.WriteLine("Reverse String:{0} ", s2);
        }
    }
}
