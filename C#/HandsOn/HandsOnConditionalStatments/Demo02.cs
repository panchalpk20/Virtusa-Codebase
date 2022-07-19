using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConditionalStatements
{
    class Demo02
    {
        static void  Main()
        {
            //largest no of given 3 no's
            //nested if
            byte a, b, c;
            Console.WriteLine("Enter any 3 no's");
            a = byte.Parse(Console.ReadLine());
            b = Convert.ToByte(Console.ReadLine());
            c = byte.Parse(Console.ReadLine());
            if(a>b)
            {
                if (a > c)
                {
                    Console.WriteLine("{0} is bigger ", a);
                }
                else
                    Console.WriteLine("{0} is bigger ", c);
            }
            else
            {
                if(b>c)
                {
                    Console.WriteLine("{0} is bigger ", b);
                }
                else
                    Console.WriteLine("{0} is bigger ", c);
            }

        }
    }
}
