using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HansOnDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Value types
            //integer types
           
            byte student_age = 21;
            short emp_salary = 4566;
            int emp_no = 3233;
            long population = 40834094343093;
            //unsigned integeres
            uint student_marks = 789;
            sbyte student_std = 3;
            ushort customer_id = 4208;
            ulong student_rollno = 30248334;
            char c = '3';
            bool isPassed = true;
            //floating points
            double percenge = 67.3;
            float weight = 66.4f;//float values end with suffix f or F
            decimal stock_price = 433232.33342M; //decimal value end with M or m

            //reference types
            string str = "Hello Good Morning";
            string name = "Raj";
            //Objec datatypes access all the values
            object obj = 45;
            object obj1 = "Ram";
            //print variable values
            Console.WriteLine(str);
            //Formating output
            Console.WriteLine("Hello " + name); //Hello Raj
            Console.WriteLine("Hello {0} ", name);
            Console.WriteLine("Hello {0} Your Age is {1}", name, student_age);
            Console.WriteLine($"Name {name} Age {student_age} ");
            Console.ReadKey(); //It reads ouput window untile user press the key



        }
    }
}
