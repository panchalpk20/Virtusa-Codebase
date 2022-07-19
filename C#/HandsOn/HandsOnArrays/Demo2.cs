using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArray
{
    class Demo2
    {
        static void Main()
        {
            char []keys = new char[4] { 'a', '3', 'r', 'o' };
            object[] ob = { "suren", 12, 34.5, true };
            string[] flowers = { "Rose", "Lilly", "Jasmine", "Tulips" };
            Console.WriteLine("Enter flower name");
            bool flag = false;
            string flower = Console.ReadLine();
            foreach(string s in flowers)
            {
                if (flower == s)
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
                Console.WriteLine("Flower is exist");
            else
                Console.WriteLine("Flower is not exist");
        }
    }
}
