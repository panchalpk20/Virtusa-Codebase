using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnMethods
{
    class Demo1
    {
        public string greet="Welcome Users"; //class-variable
        public void HelloUsers()
        {
            Console.WriteLine("Hello Users..");
            Console.WriteLine(greet);
        }
        public void Greet(string name)
        {
            Console.WriteLine("Hello " + name);
            Console.WriteLine(greet);
        }
        public void Add(int a,int b)
        {
            int result = 0; //local variable
            result = a + b;
            Console.WriteLine("Result: " + (a + b));
            Console.WriteLine(greet);
        }
    }
    class Test_Demo1
    {
        static void Main()
        {
            Demo1 obj = new Demo1(); //obj is the Demo1 object 
            obj.HelloUsers(); //calling method Hello
            obj.Greet("Divang");
            obj.Greet("Goutham");
            obj.Add(2, 4);
            obj.Add(4,4);
        }
    }

}
