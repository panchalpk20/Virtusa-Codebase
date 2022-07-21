using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnMethods
{
    class Demo2
    {
       public double Sqaure(double d)
        {
            double result = 0;
            result = d * d;
            return result;
           
        }
        public string Greet(string name)
        {
            return "Good Morning ," + name;
        }
        public bool IsEven(int no)
        {
            bool result = no % 2 == 0 ? true : false;
            return result;
        }
        public int Sum(int []a) //array as a parameter
        {
            int result = 0;
            foreach(var k in a)
            {
                result = result + k;
            }
            return result;
        }
    }
    class Test_Demo2
    {
        static void Main()
        {
            Demo2 obj = new Demo2();
            double d=obj.Sqaure(10);
            d = obj.Sqaure(2.3);

            Console.WriteLine(d);
            Console.WriteLine(obj.Greet("Ranjeet"));
            bool result = obj.IsEven(10);
            Console.WriteLine(result);
            Console.WriteLine(result ? "Even" : "Odd");
            if (obj.IsEven(20))
            {
                Console.WriteLine("Even Number");
            }
            else
                Console.WriteLine("Odd Number");
            int[] numbers = { 12, 23, 34, 45, 56 };
            int r1=obj.Sum(numbers);
            int r=obj.Sum(new int[] { 23, 34, 45, 6, 7 });
            Console.WriteLine(r);
        }
    }
}
