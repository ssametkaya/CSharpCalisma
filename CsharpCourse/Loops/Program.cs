using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 100; i++)
            //{
            //Console.WriteLine(i);
            //}
            //Console.WriteLine("Bitti");

            //for (int i = 1; i < 100; i=i+2)
            //{
            //Console.WriteLine(i);
            //}

            //for (int i = 100; i >= 0; i--)
            //{
            //Console.WriteLine(i);
            //}

            //for (int i = 100; i >= 0; i=i-2)
            //{
            //Console.WriteLine(i);
            //}

            //for (int i = 1; i <= 100; i=i*2)
            //{
            //Console.WriteLine(i);
            //}

            //for (double i = 100; i >= 1; i = i / 2)
            //{
            //Console.WriteLine(i);
            //}

            //int sayi = 100;
            //while (sayi >= 0)
            //{
            //Console.WriteLine(sayi);
            //sayi=sayi-2;
            //}
            //Console.WriteLine("Sayı şimdi {0}", sayi);

            //int number =100 ;

            //do
            //{
            //Console.WriteLine(number);
            //number--;
            //} while (number>=0);

            string[] ögrenciler = new string[3] { "samet", "yigit", "ahmet" };

            foreach (var ögrenci in ögrenciler)
            {
                Console.WriteLine(ögrenci);
            }
            Console.ReadLine();
        }
    }
}
