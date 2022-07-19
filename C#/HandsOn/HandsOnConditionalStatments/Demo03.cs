using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConditionalStatements
{
    class Demo03
    {
        static void Main()
        {
            //if-else-if lader
            int m1, m2, m3, m4, m5;
            Console.WriteLine("Enter M1 Marks");
            m1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter M2 Marks");
            m2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter M3 Marks");
            m3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter M4 Marks");
            m4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter M5 Marks");
            m5 = int.Parse(Console.ReadLine());
           
            double tot, avg;
            tot = m1 + m2 + m3 + m4 + m5;
            avg = tot / 5;
            string result = null;
            if(m1>40 && m2>40 && m3>40 && m4>40&&m5>40)
            {
                if (avg >= 70)
                {
                    result = "Distinction";
                }
                else if (avg >= 60)
                {
                    result = "FirstClass";
                }
                else if (avg >= 50)
                {
                    result = "Second Class";
                }
                else
                    result = "Third Class";
            }
            else
            {
                Console.WriteLine("Result:Faild");
            }
            if (result != null)
                //Console.WriteLine("Result:{0} Percentage: {1}% Total: {2}", result, avg, tot);
                Console.WriteLine($"Result:{result} Percentage:{avg} Total:{tot}");
            Console.ReadKey();

        }
    }
}
