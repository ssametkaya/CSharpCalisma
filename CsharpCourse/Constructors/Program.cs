using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(10);

            customerManager.List();

            Product product = new Product(2, "Computer");


            EmployeeManager employeeManager = new EmployeeManager(new FileLogger());
            employeeManager.Add();

            


            Console.ReadLine();
        }
    }


    class CustomerManager
    {
        private int _count;
        public CustomerManager(int count)
        {
            _count = count;
        }
        public void List()
        {
            Console.WriteLine("Listed! {0} items", _count);
        }

        public void Add()
        {
            Console.WriteLine("Added!");
        }
    }

    class Product
    {
        public Product()
        {

        }

        private int _id;
        private string _name;

        public Product(int id,string name)
        {
            _id = id;
            _name = name;

        }

    }

    class EmployeeManager
    {
        private ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;

        }

        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added!");
        }
    }


    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to File");
        }
    }


    class SmsLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to sms");
        }
    }
    interface ILogger
    {
        void Log();
    }
}
