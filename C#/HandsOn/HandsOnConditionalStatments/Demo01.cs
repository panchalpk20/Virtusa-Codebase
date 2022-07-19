using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConditionalStatements
{
    class Demo01
    {
        static void Main()
        {
            //simple-if-else
            int no = 121;
            if (no % 2 == 0)
                Console.WriteLine("{0} is Even", no);
            else
                Console.WriteLine("{0} is Odd", no);
        }
    }
}
