using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace HandsOnNonGenericCollections
{
    class Demo5
    {
        static void Main()
        {
            Queue queue = new Queue();
            queue.Enqueue('a');
            queue.Enqueue('c');
            queue.Enqueue('u');
            queue.Enqueue('9');
            queue.Enqueue('1');
            char c = (char)queue.Peek(); //return first value;
            queue.Dequeue(); //removes first item
            foreach (var i in queue)
                Console.WriteLine(i);
        }
    }
}
