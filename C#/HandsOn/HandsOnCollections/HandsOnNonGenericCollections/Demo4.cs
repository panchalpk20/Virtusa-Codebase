using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace HandsOnNonGenericCollections
{
    class Demo4
    {
        static void Main()
        {
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            stack.Push(50);
            stack.Push(60);
            int k = (int)stack.Peek(); //returns last add value
            stack.Pop(); //remove last added value
            foreach (var item in stack)
                Console.WriteLine(item);
        }
    }
}
