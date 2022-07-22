using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnNonGenericCollections
{
    class TicketBooking
    {
        public bool BookTicket(int count)
        {
            try
            {
                if (count <= 3)
                {
                    return true;
                }
                else
                    throw new TicketException("Count is Exceed");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
    class Test_TicketBooking
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter no of Tickets");
                int count = int.Parse(Console.ReadLine());
                TicketBooking ticket = new TicketBooking();
                bool result=ticket.BookTicket(count);
                if(result)
                {
                    Console.WriteLine("Tickets are booked.");
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }


    internal class TicketException : Exception
    {
        public TicketException()
        {
        }

        public TicketException(string message) : base(message)
        {
        }

    }
}
