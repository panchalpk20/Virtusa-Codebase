using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArray
{
    class Demo1
    {
        static void Main()
        {
            Console.WriteLine("How many numbers store in the array");
            int n = int.Parse(Console.ReadLine());
            int[] no = new int[n];
            Console.WriteLine("Size of the array: " + no.Length);
            //Read array values from the input
            for(int i=0;i<n;i++)
            {
                Console.Write("Enter a[{0}] value: ", i);
                no[i] = int.Parse(Console.ReadLine());
            }
            //print all the array values
            foreach (int k in no)
                Console.WriteLine(k);
        }
    }
}
