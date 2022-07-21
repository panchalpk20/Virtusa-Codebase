using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5.HandsOnMethodModifiers
{
    class Demo03
    {
        //overloading methods
        public static void Add(int a,int b)
        {
            Console.WriteLine(a + b);
        }
        public static int Add(int a)
        {
            return a + a;
        }
        public static void Add(double a,double b)
        {
            Console.WriteLine(a + b);
        }
        public void Add(int a,int b,int c)
        {
            Console.WriteLine(a + b + c);
        }
        static void Main()
        {
            Demo03.Add(2);
            Demo03.Add(1, 2);
            Demo03.Add(12.3, 34.4);
        }
    }
}
