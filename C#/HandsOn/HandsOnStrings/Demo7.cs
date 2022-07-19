using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnStrings
{
    class Demo7
    {
        static void Main()
        {
            string[] email = { "Gmail.com","Yahoo.com","Yahoo.co.in","Hotmail.in" };
            foreach(string s in email)
            {
                if (s.EndsWith("in"))
                    Console.WriteLine(s);
                //if(s.StartsWith(("y").ToUpper()))
                //{
                //    Console.WriteLine(s);
                //}
            }
            Console.ReadKey();

        }
    }
}
