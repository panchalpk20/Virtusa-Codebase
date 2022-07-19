using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnStrings
{
    class Demo1
    {
        static void Main()
        {
            string str = "Hello World";
            char ch = str[2];
            int len = str.Length;
            string Name = "Rohan";
            string s1;
            s1=String.Copy(Name); //s1=Name
            Console.WriteLine(s1);
            string s2 = "Welcome";
            string s3 = "David";
            string s4 = String.Concat(s2," "+ s3); //s2+s3
            Console.WriteLine(s4);

        }
    }
}
