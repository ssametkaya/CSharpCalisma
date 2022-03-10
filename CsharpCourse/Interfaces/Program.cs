using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //PersonManager manager = new PersonManager();
            ////manager.Add(new Customer { Id = 1, FirstName = "Samet", LastName="Kaya", Adress="Van" });
            //Customer customer = new Customer
            //{
            //    Id = 1,
            //    FirstName = "Samet",
            //    LastName = "Kaya",
            //    Adress="Van"

            //};

            //Student student = new Student
            //{
            //    Id = 111,
            //    FirstName = "Ahmet",
            //    LastName = "Kazak",
            //    Departmant = "Electronic and Communications"

            //};
            //manager.Add(customer);
            //manager.Add(student);

            //CustomerManager customerManager = new CustomerManager();
            ////customerManager.Add(new SqlServerCustomerDal());

            //customerManager.Add(new OracleServerCustomerDal());

            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new SqlServerCustomerDal(),
                new OracleServerCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();

        }


        interface IPerson
        {
            int Id { get; set; }
            string LastName { get; set; }
            string FirstName { get; set; }
        }

        class Customer : IPerson
        {
            public int Id { get; set; }
            public string LastName { get; set; }
            public string FirstName { get; set; }

            public string Adress { get; set; }
        }

        class Student : IPerson
        {
            public int Id { get; set; }
            public string LastName { get; set; }
            public string FirstName { get; set; }

            public string Departmant { get; set; }
        }

        class Worker : IPerson
        {
            public int Id { get; set; }
            public string LastName { get; set; }
            public string FirstName { get; set; }

            public string Departmant { get; set; }
        }


        class PersonManager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine(person.FirstName);
                Console.WriteLine(person.LastName);

            }

        }
    }


}
