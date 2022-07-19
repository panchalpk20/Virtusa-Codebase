using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnStrings
{
    class Demo5
    {
        static void Main()
        {
            string s = "Apple phone";
            Console.WriteLine(s.IndexOf('o'));
            Console.WriteLine(s.IndexOf('e'));
            Console.WriteLine(s.LastIndexOf('e'));
            Console.WriteLine(s.IndexOf('p', 5));
            Console.WriteLine(s.ToUpper());
            Console.WriteLine(s.ToLower());
            string s1 = "   Abcd   ";
            Console.WriteLine(s1.TrimStart());
           Console.WriteLine(s1.TrimEnd());
           Console.WriteLine(s1.Trim());

        }
    }
}
