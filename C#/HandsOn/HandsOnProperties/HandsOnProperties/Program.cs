using System;

namespace HandsOnProperties
{
    class Employee
    {
        private int employeeId;
        private string employeeName;
        //property for employeeId
        public int EmployeeId
        {
            get { return employeeId; } //get always return value of private variable using return
            set { if(value>0)
                    employeeId = value;
                        } //set value to private variable at runtime using property
        }
        //property for employeeName
        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }
        public void Details()
        {
            Console.WriteLine("Id:{0} Name:{1}", employeeId, employeeName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.EmployeeId = -1989;
            e1.EmployeeName = "Mark";
            e1.Details();
            Employee e2 = new Employee();
            e2.EmployeeId = 432093;
            e2.EmployeeName = "Peter";
            e2.Details();
          
        }
    }
}
