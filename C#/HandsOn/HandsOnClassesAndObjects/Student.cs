using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassesAndObjects
{
    class Student
    {
        //class-variables
        public int studentId;
        public string studentName;
        public DateTime dob;
        public string std;
        //methods
        public void Show()
        {
            Console.WriteLine($"ID:{studentId} " +
                $"Name:{studentName} DOB:{dob} STD:{std}");
        }
    }
}
