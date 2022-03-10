using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            IWorker[] workers = new IWorker[3]
            {
                new Managers(),
                new Workers(),
                new Robot()
            };

            IEat[] eats = new IEat[2]
            {
                new Managers(),
                new Workers(),
               
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }

            

            foreach (var eat in eats)
            {
                eat.Eat();
            }

            Console.ReadLine();
        }
    }


    interface IWorker
    {
        void Work();
    }

    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();
    }

    class Managers : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Managers Eat");
        }

        public void GetSalary()
        {
            Console.WriteLine("Managers Get Salary");
        }

        public void Work()
        {
            Console.WriteLine("Managers Work");
        }
    }

    class Workers : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Workers Eat");
        }

        public void GetSalary()
        {
            Console.WriteLine("Workers Get Salary");
        }

        public void Work()
        {
            Console.WriteLine("Workers Work");
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot Works");
        }
    }
}
