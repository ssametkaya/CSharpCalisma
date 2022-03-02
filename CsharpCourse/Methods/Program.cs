using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Add();
            Add();
            Add();
            Add();
            var result = Add2();
            Console.WriteLine(result);
            Console.ReadLine();


        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }


        static int Add2(int number1 = 22, int number2 = 35)
        {

            var result = number1 + number2;

            return result;

        

        }
    }
}
