using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collectinos
{
    class Program
    {
        static void Main(string[] args)
        {

            //string[] cities = new string[2] { "Isparta", "Van" };

            //cities = new string[3];
            //Console.WriteLine(cities[1]);

            //ArrayList cities = new ArrayList();
            //cities.Add("Ankara");
            //cities.Add("Ordu");
            //cities.Add(15);
            //cities.Add("Van");
            //cities.Add("a");
            //cities.Add(1515.5);

            //foreach (var city in cities)
            //{
            //    Console.WriteLine(city);
            //}


            //List<string> cities = new List<string>(); // Listler ile tip bazlı çalışılır belirlenen değişken türü dışında değişken eklenemez.

            //cities.Add("Ankara");
            //cities.Add("Van");
            //cities.Add(15);
            //foreach (var city in cities)
            //{
            //    Console.WriteLine(city);
            //}




            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { FirstName = "samet", Id = 123 });
            //customers.Add(new Customer { FirstName = "ahmet", Id = 123123 });

            //List<Customer> customers = new List<Customer>
            //{

            //    new Customer { FirstName = "yigit", Id = 23232 },

            //    new Customer { FirstName = "dogukan", Id = 5656 }
            // };

            //foreach (var customer in customers)
            //{
            //    Console.WriteLine(customer.FirstName);
            //}
            //Console.ReadLine();






        }


    }


    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}


