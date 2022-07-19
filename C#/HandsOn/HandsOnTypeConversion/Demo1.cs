using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTypeConversion
{
    internal class Demo1
    {
        static void Main()
        {
            string s = "120A";
            int i;
            int.TryParse(s, out i); //TryParse() convert string to any value type and if value is not compatable returns default value
            Console.WriteLine(i);
        }
    }
}
