using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClass
{
    class Program
    {
        static void Main(string[] args)
        {

            

            // Instanciation d'un objet de type (class) Customer
            Customer client1 = new Customer("Sébastien", "Pertus", "Toulouse");
            client1.Birthday = new DateTime(1976, 10, 23);
            Console.WriteLine(client1.GetCompleteName());

            Customer client2 = new Customer();
            //Customer client2 = Customer.CreateNewCustomer();

            client2.City = "Paris";
            client2.FirstName = "Jean Sébastien";
            client2.LastName = "Dupuys";
            client2.Birthday = new DateTime(1977, 11, 10);
            Console.WriteLine(client2.GetCompleteName());

            var dif = Customer.DifferenceAge(client1, client2);

            Console.WriteLine(dif.ToString());


            Console.Read();


        }
    }

}
