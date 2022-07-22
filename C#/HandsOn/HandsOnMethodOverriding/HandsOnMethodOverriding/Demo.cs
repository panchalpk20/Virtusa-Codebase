using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnMethodOverriding
{
    class AA
    {
        public void M1() { }
    }
    class BB:AA
    {
        public void M2() { 
       
        }
    }

    class Demo
    {
        static void Main()
        {
            AA ob = new AA(); //access AA members
            ob.M1();
            BB ob1 = new BB();//Access AA,BB members
            ob1.M1();
            ob1.M2();
            AA ob2 = new BB();//Access AA members and override members of BB
            ob2.M1();
        }
    }
}
