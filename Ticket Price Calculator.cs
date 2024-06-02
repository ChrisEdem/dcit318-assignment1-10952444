using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketPriceCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            double ticketPrice;
            if (age >= 65 || age <= 12)
            {
                ticketPrice = 7;
            }
            else
            {
                ticketPrice = 10;
            }

            Console.WriteLine($"Your ticket price is: GHC{ticketPrice}");
        }
    }
}


