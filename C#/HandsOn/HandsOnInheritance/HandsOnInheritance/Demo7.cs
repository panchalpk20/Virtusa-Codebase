using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInheritance
{
    //Method-hiding in Inheritance
    class Employee
    {
        public int eId;
        public string eName;
        public void Details()
        {
            Console.WriteLine("ID: " + eId);
            Console.WriteLine("Ename: " + eName);
        }
    }
    class Manager:Employee
    {
        public string type;
        new  public void Details()
        {
            base.Details(); //calls Employee Details()
            Console.WriteLine("Manager Type: " + type);
        }
    }
    class Demo7
    {
        static void Main()
        {
            Manager obj = new Manager();
            obj.eId = 1000;
            obj.eName = "Jon";
            obj.type = "Product Manager";
            obj.Details(); //invoking Manager Details()
            Employee obj2 = new Employee();
            obj2.Details(); //Invoking Employee Details()
            Employee obj3 = new Manager();
            obj3.Details(); //Invoiking Employee Details()
        }
    }
}
