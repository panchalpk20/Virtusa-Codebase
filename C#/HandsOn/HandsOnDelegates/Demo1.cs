using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDelegates
{
    public delegate void myDalegate();
    class Demo1
    {
       
        public static void Print()
        {
            Console.WriteLine("Printing..");
        }
        public static void M(myDalegate d)
        {
            d(); //invoke delegate
        }
        static void Main()
        {
            M(Print);
          
        }
    }
}
