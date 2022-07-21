using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnMethods
{
    internal class Calculate
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
        public float Add(float a, float b)
        {
            return a + b;
        }
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        static void Main()
        {
            Calculate calc = new Calculate();
            int result=calc.Add(1, 2);
            result=calc.Add(2, 3, 4);
            float float_result=calc.Add(12.3f, 23.4f);
            double double_result=calc.Add(12.2, 34.5);
            Console.WriteLine(double_result);
        }
    }
}

