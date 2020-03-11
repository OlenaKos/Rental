using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer("Alex");
            Movie movie = new Movie("Matrix", 1);
            Rental rental = new Rental(movie, 2);

            customer.Rentals = rental;
            Console.WriteLine(customer.Statement());

            // Delay.
            Console.ReadKey();
        }
    }
}
