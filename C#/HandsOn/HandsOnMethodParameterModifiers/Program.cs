using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnMethodModifiers
{
    class Program
    {
        public static void M(int a)
        {
            a = 2 * a;
            Console.WriteLine("a={0}", a);
        }
        public static void M1(ref int a)
        {
            a = 2 * a;
            //Console.WriteLine("a={0}", a);
        }
        public static void Add(int a,int b,ref int c)
        {
           c = a + b;
        }
        static void Main(string[] args)
        {
            
            int a = 10;
            M(a);
            Console.WriteLine("a={0}", a); //10
            M1(ref a);
            Console.WriteLine("a={0} ", a); //20
            int b = 20;
            int c = 0;
            Add(a, b, ref c);

        }
    }
}
