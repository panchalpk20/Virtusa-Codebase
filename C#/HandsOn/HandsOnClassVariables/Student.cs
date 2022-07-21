using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassVariables
{
    internal class Student
    {
        public readonly int studentId;
        public readonly string studentName;
        public string std;
        public Student(int studentId, string studentName, string std)
        {
            this.studentId = studentId;
            this.studentName = studentName;
            this.std = std;
        }
        public void Details()
        {
            Console.WriteLine($"ID:{studentId} Name:{studentName} STD:{std}");
        }
    }
    class Test_Student
    {
        static void Main()
        {
            Student student = new Student(389, "Dishant", "IV");
            student.std = "V";
            student.Details();
            Student s2 = new Student(342, "Gourav", "V");
            s2.Details();
        }
    }

}
