using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConstructors
{
    internal class Rectangle
    {
        private int l;
        private int w;

        public Rectangle(int l, int w)
        {
            this.l = l;
            this.w = w;
        }
        public void Area()
        {
            Console.WriteLine("Area of Rectangle: " + (l * w));
        }
        static void Main()
        {
            Rectangle r = new Rectangle(3, 4);
            r.Area();
        }
    }
}
