using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnIndexers
{
    internal class Demo2
    {
        Dictionary<char, int> obj = new Dictionary<char, int>();
        public int this[char ch]
        {
            get { return obj[ch]; }
            set { obj[ch] = value; }
        }
        //public int this[int index,string val]
        //{
        //    get { return a[index]; }
        //    set
        //    {
        //        if (index < a.Length)
        //        {
        //            a[index] = value;
        //            str[index]=val;
        //        }


        //    }
        //}
        //public string this[int index]
        //{
        //    get { return a[index] + "\n" + str[index]; }
        //}

        static void Main()
        {
            Demo2 demo = new Demo2();
            demo['c'] = 10;
            demo['r'] = 39;
            Console.WriteLine(demo['r']);
                
        }
    }
}
