using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            Customer customer = new Customer();

            customer.City = "Ordu";
            customer.Id = 123;
            customer.FistName = "Samet";
            customer.LastName = "Kaya";

            Customer customer2 = new Customer
            {
                City="İstanbul", LastName="Kazak", FistName="Ahmet", Id=1234
            };

            Console.WriteLine(customer.City);
            Console.WriteLine(customer2.City);

            Console.ReadLine();
        }
    }
}
