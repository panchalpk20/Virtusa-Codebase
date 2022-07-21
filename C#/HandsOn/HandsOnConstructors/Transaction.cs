using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConstructors
{
    internal class Transaction
    {
        private Transaction() //prevents create object
        {

        }
    }
    class Test
    {
        static void Main()
        {
            //Transaction obj = new Transaction(); //Prevent object creation
        }
    }
}
