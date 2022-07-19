using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnStrings
{
    class Demo9
    {
        static void Main()
        {
            double salary = 12000;
            string s = string.Format("{0:C}",salary); //retun curreny value with symbol
            Console.WriteLine(s);
            decimal discount = 12.40430349M;
            s = string.Format("{0:F2}", discount); //limiting fraction values
            Console.WriteLine(s);
            long l = 3243429039032;
            s = string.Format("{0:E}", l); //exponentiol
            Console.WriteLine(s);
            double k = 2.34;
            s = string.Format("{0:P}", k); //return percentage
            Console.WriteLine(s);
            DateTime dt = DateTime.Now; //return system date & time
            Console.WriteLine(dt);
            s = string.Format("{0:d}", dt); //return MM/DD/YY
            Console.WriteLine(s);
            s = string.Format("{0:t}", dt); //retunr HH:MM
            Console.WriteLine(s);
            s = string.Format("{0:T}", dt); //retun HH:MM:SS
            Console.WriteLine(s);
            s = string.Format("{0:D}", dt); //retunrs date in long format
            Console.WriteLine(s);

           
        }
    }
}
