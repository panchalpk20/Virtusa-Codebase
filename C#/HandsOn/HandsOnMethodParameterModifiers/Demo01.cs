using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnMethodModifiers
{
    class Demo01
    {
        public static void Add(int a,int b,out int c)
        {
           c = a + b;
        }
        public static bool Validate(string uname,string pwd,out string err)
        {
            if(uname=="Admin" && pwd=="12345")
            {
                err = "Valid User";
                return true;
                
            }
            else
            {
                err = "InValid User";
                return false;
               
            }

        }
        static void Main()
        {
            int a = 10, b = 20, c;
            Add(a, b, out c);
            Console.WriteLine("c: "+ c);
        }
    }
}
