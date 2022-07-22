using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnProperties
{
    internal class Customer
    {
        private string name;
        private string email;
        private string mobile;
        public string Mobile { set => mobile = value; } //write only property

        public Customer(string name, string email)
        {
            this.name = name;
            this.email = email;
        }
        //Read only properties
        public string Name { get => name; }
        public string Email { get => email; }

    }
    class Test_Customer
    {

        static void Main()
        {
            Customer obj = new Customer("Vinod", "vindo@gmail.com");
            obj.Mobile = "4320984329432";
            Console.WriteLine($"Name{obj.Name} Email:{obj.Email}");
        }

    }

}
