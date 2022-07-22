using System;

namespace HandsOnIndexers
{
    class Sample
    {
        private int[] a = new int[5];
        private string[]str= new string[5];
        //indexers
        public int this[int index]
        {
            get { return a[index]; }
            set
            {
                if (index < a.Length)
                    a[index] = value;

            }
        }
      
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 12, 23, 34 };
            Console.WriteLine(n[1]);
            string s = "ABCDEDF";
            Console.WriteLine(s[2]);
            Sample ob = new Sample();
            ob[0] = 10; //indexer set accessor invoke.
            ob[1] = 20;
            ob[2] = 30;
            ob[3] = 40;
            Console.WriteLine(ob[0]); //10 //indexer get accessor invoke
            DateTime dt = new DateTime();                      
        }
    }
}
