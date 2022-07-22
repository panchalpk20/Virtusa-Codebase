using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnProperties
{
    class Login
    {
        //Automatic Properties
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } = "Admin"; //set default value to the Property
        static void Main()
        {
            Login login = new Login();
            login.Role = "Admin";
        }

    }
}
