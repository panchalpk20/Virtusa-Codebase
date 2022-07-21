using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnMethods
{
    class Demo3
    {
        public int a, b;
        public static int c;
        public static void Greet(string name="David")
        {
            Console.WriteLine("Hello " + name);
        }
        public static int Add(int a,int b=8) //default parameter value
        {
            return a + b;
        }
        public static void M()
        {
            //non static members are not allowd inside static class
            c = 100;
        }
    }
    class Test_Demo3
    {
        static void Main()
        {
            Demo3.Greet("Mark");
            Demo3.Greet(); //name="David"
            int result = Demo3.Add(2, 4);
            Console.WriteLine(result);
            result = Demo3.Add(2); //b=8
            //named paramters
            int result2 = Demo3.Add(b:4,a:2);
            Demo3.Greet(name: "Sachin");
            
        }
    }

}
