using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnIndexers
{
    class Demo1
    {
        int[,] a = new int[3, 2];
        public int this[int i, int j]
            {
            get { return a[i, j]; }
            set { a[i, j] = value; }
            }
        static void Main()
        {
            Demo1 obj = new Demo1();
            obj[0, 0] = 10;
            obj[0, 1] =20;

            obj[1, 0] = 30;
            obj[1, 1] = 40;

            obj[2, 0] = 50;
            obj[2, 1] = 60;

            Console.WriteLine(obj[0, 1]); //10

        }
    }
}
