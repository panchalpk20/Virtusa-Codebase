using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArray
{
    internal class Demo41
    {
        static void Main()
        {
            string[,] data = new string[,]
            {
                {"E0001","Harsit" },
                {"E0002","HemRaj" },
                {"E0003","Jaya" },
                {"E0004","Karanveer" },
                {"E0005","Manish" }

            };
            Console.WriteLine("Enter Id");
            string empId = Console.ReadLine();
            int flag = 0;
            for(int i = 0; i <5; i++)
            {
                if (data[i,0]==empId)
                {
                    Console.WriteLine("Employee Name: " + data[i, 1]);
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.WriteLine("Invalid Id");
        }
    }
}
