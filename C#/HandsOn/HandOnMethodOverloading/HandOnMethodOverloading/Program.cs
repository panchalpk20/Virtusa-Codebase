using System;

namespace HandOnMethodOverloading
{
    class Calculate
    {
        public void Add(int a,int b)
        {
            int add = a + b;
            Console.WriteLine("Addition: " + add);
        }
        public void Add(int a,int b,int c)
        {
            int add = a + b + c;
            Console.WriteLine("Addition: " + add);
        }
        public void Add(double a,double b)
        {
            double add = a + b;
            Console.WriteLine("Addition: " + add);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculate calculate = new Calculate();
            calculate.Add(12.2, 23.4);
            calculate.Add(2, 3, 4);
            calculate.Add(2, 3);
            Console.WriteLine("Hello");
        }
    }
}
