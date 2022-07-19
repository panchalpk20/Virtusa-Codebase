using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnIterativeStatements
{
    class Demo3
    {
        static void Main()
        {
            //for(int i=1;i<=100;i++)
            //{
            //    Console.Write(i+"\t");
            //}
            int i = 1;
            //for(;i<100;i++)
            //{
            //    Console.Write(i + "\t");
            //}
            //for (; i <= 100;)
            //{
            //    Console.Write(i + "\t");
            //    i++;
            //    if (i == 20)
            //        break;
            //}
            //for (; ; )
            //{
            //    Console.Write(i + "\t");
            //    i++;
            //    if (i == 10)
            //        break;
            //}
            for(;i<=100;i++) //print odd values

            {
                
                if (i % 2 == 0)
                    continue;
                Console.Write(i + "\t");
            }

            
        }
    }
}
