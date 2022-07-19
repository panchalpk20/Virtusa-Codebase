using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnStrings
{
    class Program
    {
        static void Main(string[] args)
        {
           // String obj = new String(new char[3] {'a','b','c'});
            string str = "Hello,Vaibav";
            string path = @"C:\Trainings\Dontet\CSharp"; //varbitim strings
            string path1 = @"C:\\Trainings\Dontet\CSharp";
            Console.WriteLine(path);
            Console.WriteLine(path1);
            //string functions
            Console.WriteLine("Length: " + str.Length);
            char ch = str[2]; //returns l;
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.ToLower());
            str.ToLower();
            Console.WriteLine(str);
            string s = string.Format("Hi,{0}", "Anshu");
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
