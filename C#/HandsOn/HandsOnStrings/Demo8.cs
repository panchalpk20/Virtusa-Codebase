using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnStrings
{
    class Demo8
    {
        static void Main()
        {
            string s = "All Glitters are not Gold";
            string[] str = s.Split(' ');
            Console.WriteLine(str[0]);
            foreach (string k in str)
                Console.WriteLine(k);
            string s1 = "Asp.net,vb.net C#.net";
            string[] str1 = s1.Split(' ',',') ;
            foreach (string j in str1)
                Console.WriteLine(j);
            Console.ReadKey();
          

        }
    }
}
