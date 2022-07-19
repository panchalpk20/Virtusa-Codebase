using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArray
{
    class Demo3
    {
        static void Main()
        {
            int[] nos = { 12, 23, 21, 34, 43, 32, 22, 44, 54, 33, 67, 98, 76, 65 };
            Console.WriteLine("Size: " + nos.Length); //size of the array
            Console.WriteLine("Rank: " + nos.Rank); //dimension of the array
            Array.Sort(nos);
          // Array.Reverse(nos);
            foreach (int k in nos)
                Console.WriteLine(k);

            //Console.WriteLine("Enter the value");
            //int n = int.Parse(Console.ReadLine());
            //if (Array.BinarySearch(nos, n) >= 0)
            //    Console.WriteLine("Valid value");
            //else
            //    Console.WriteLine("Invalid Value");
            int[] c = new int[4];
            Array.Copy(nos, c, 4);
            Console.WriteLine();
            foreach (int m in c)
                Console.WriteLine(m);
        }
    }
}
