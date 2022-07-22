using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnMethodOverriding
{
    class A { }
    class Student
    {
        private string name;

        public Student(string name)
        {
            this.name = name;
        }
        public  string ToString()
        {
            return "Hello " + name;
        }
    }
    class Test_Student
    {
        public static void Main()
        {
            A obj = new A();
            Console.WriteLine(obj.ToString());
            Student s = new Student("Sachin");
            Console.WriteLine(s.ToString());
            Object obj2 = new Student("Rahul");
            Console.WriteLine(obj2.ToString());
           
        }
    }
}
