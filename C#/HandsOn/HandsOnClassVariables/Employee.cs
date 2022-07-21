using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassVariables
{
    class Employee
    {
        public int employeeId; //instance variable(default)
        public string employeeName;
        public static string projectName; //chage at runtime
        public const string clientName="KFC"; //not able to change at runime
        public readonly string company = "JPMC"; //not able to chage at runtime,chage only once using constructor
        public void Details()
        {
            Console.WriteLine($"ID:{employeeId} Name:{employeeName} ProjectName:{projectName} ClientName {clientName} Company {company}");
        }
        static void Main()
        {
            Employee.projectName = "Olx";
            Employee e1 = new Employee() { employeeName = "Aniketh", employeeId = 332 };
            Employee e2 = new Employee() { employeeName = "Riyath", employeeId = 342 };
            Employee e3 = new Employee() { employeeName = "Aman", employeeId = 678 };
            e1.Details();
            e2.Details();
            e3.Details();
            Employee.projectName = "Music APP";
            Employee e4 = new Employee() { employeeName = "Haresh", employeeId = 987 };
            Employee e5 = new Employee() { employeeName = "Madhu", employeeId = 9587 };
            e5.Details();
            Console.WriteLine("ID: " + e4.employeeId);
            Console.WriteLine("Name: " + e4.employeeName);
            Console.WriteLine("Company: " + e4.company);
            Console.WriteLine("Project: " + Employee.projectName);
            Console.WriteLine("Client: " + Employee.clientName);
        }
    }
}
