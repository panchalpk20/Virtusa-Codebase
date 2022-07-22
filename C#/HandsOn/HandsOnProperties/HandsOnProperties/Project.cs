using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnProperties
{
    internal class Project
    {
        //Automatic Properities
        public string Name { get; set; }
        public string Description { get; set; } = "Project Description";
        public int ID { get; set; } 
        static void Main()
        {
            Project p = new Project();
            p.ID = 789;
            p.Name = "SMS";
            Console.WriteLine($"ID:{p.ID} Name:{p.Name} Description:{p.Description}");
            
        }

    }
}
