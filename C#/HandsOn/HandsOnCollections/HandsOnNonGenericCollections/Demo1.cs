using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace HandsOnNonGenericCollections
{
    class Demo1
    {
        static void Main()
        {
            ArrayList list = new ArrayList() { 12, 34, 45, 56, 67, 88 };
            list.Add(90); //item added at end of the colleciton
            list.Insert(1, 33);
            //access a value
            int k = (int)list[2];
            //acess all the values
            foreach (var v in list)
                Console.WriteLine(v);
        }

    }
}
