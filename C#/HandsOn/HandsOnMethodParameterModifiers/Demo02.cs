using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnMethodModifiers
{
    class Demo02
    {
        public static void Sum(params int []a)
        {
            int sum = 0;
           
            foreach(int k in a)
            {
                sum = sum + k;
            }
            Console.WriteLine("Sum={0}", sum);
        }
        public static void Add(int a,params int []n) //params paramter is alway lasts paramter in the method defination
        {
            int sum = 0;

            foreach (int k in n)
            {
                sum = sum + k;
            }
            sum = sum + a;
            Console.WriteLine("Sum={0}", sum);
        }
        static void Main()
        {
            Sum(new int[] { 12, 34, 45, 56 });
            int[] n = new int[3] { 1, 2, 3 };
            Sum(n);
            Sum(12, 23, 34, 45);
            Sum(2, 3, 4, 5, 6, 78);
            Add(10, 23, 4, 5, 67, 78);
        }
    }
}
