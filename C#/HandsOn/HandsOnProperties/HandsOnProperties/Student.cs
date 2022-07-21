using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnProperties
{
    class Student
    {
        private int studentId;
        private string studentName;
        private int age;

        public int StudentId { get => studentId; set => studentId = value; }
        public string StudentName { get => studentName; set => studentName = value; }
        public int Age { get => age; set => age = value; }
    }
}
