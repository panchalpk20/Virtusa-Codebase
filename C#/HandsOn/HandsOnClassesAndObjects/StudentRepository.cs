using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassesAndObjects
{
    class StudentRepository
    {
        private Student[] students = new Student[5]; //inmemory data source
        int idx = 0;
        public void AddStudent(Student s)
        {
            //add student oject to array
            if (idx < students.Length)
            {
                students[idx] = s;
                idx++;
            }
            else
                Console.WriteLine("Class is Full..");
        }
        public Student GetStudent(int studentId)
        {
            foreach(Student s in students)
            {
                if(s!=null)
                {
                    if (s.studentId == studentId)
                    {
                        return s;
                    }
                }
            }
            return null; //when student is not found in the array
        }
        public Student[] GetAllStudents()
        {
            return students; //students is the array type.
        }
    }
    class Test_Student
    {
        static void Main()
        {
            StudentRepository studentRepository = new StudentRepository();
            do
            {
                Console.WriteLine("1.Addstudent");
                Console.WriteLine("2.GetStudent");
                Console.WriteLine("3.GetAllStudents");
                Console.WriteLine("4.Exit");
                Console.WriteLine("Enter your Choice");
                int ch = int.Parse(Console.ReadLine());
               
                switch(ch)
                {
                    case 1:
                        {
                            //Add Student
                            Student student = new Student();
                            Console.WriteLine("Enter Student Id");
                            student.studentId = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Name");
                            student.studentName = Console.ReadLine();
                            Console.WriteLine("Enter DOB");
                            student.dob = DateTime.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Std");
                            student.std = Console.ReadLine();
                            studentRepository.AddStudent(student);

                        }
                        break;
                    case 2:
                        {
                           //Get Student By Id
                            Console.WriteLine("Enter Student Id");
                            int studentId = int.Parse(Console.ReadLine());
                            Student student=studentRepository.GetStudent(studentId);
                            if (student != null)
                            {
                                student.Show();
                            }
                            else
                                Console.WriteLine("Invalid Studnet Id");

                        }
                        break;
                    case 3:
                        {
                            //Get All Students
                            Student []students=studentRepository.GetAllStudents();
                            foreach(var student in students)
                            {
                                if(student!=null)
                                {
                                    student.Show();
                                }
                            }
                        }
                        break;
                    case 4:
                        {
                            Environment.Exit(0); //exit the application
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            } while (true);
        }
    }
}
