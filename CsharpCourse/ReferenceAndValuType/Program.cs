using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValuType
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;

            Console.WriteLine(number2);


            string[] cities1 = new string[] { "ordu", "van", "ısparta" };
            string[] cities2 = new string[] { "istanbul", "bursa", "tekirdağ" };

            cities2 = cities1;
            cities1[0] = "ankara";

            Console.WriteLine(cities2[0]);




            Console.ReadLine();
        }
    }
}
