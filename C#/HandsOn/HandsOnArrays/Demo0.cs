using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArray
{
    internal class Demo0
    {
        static void Main()
        {
            int[] n = new int[10];
            n[0] = 10;
            n[4] = 78;
            foreach (int k in n)
                Console.WriteLine(k);
        }
    }
}
