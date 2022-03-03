using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOrnekler
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Bir Sayıyı Giriniz:");

            //int sayi = Convert.ToInt32(Console.ReadLine());

            //tekcift(sayi);
            //Console.ReadKey();
            
            Console.WriteLine(Add(6,5,4,3,2,1));
            Console.ReadLine();
           
        }
        static int Add(params int[] numbers)
        {
            return numbers.Sum();
        }



        //static void tekcift (int a)
        //{
            //if (a % 2 ==0 )
            //{
                //Console.WriteLine("Sayı Cift");
            //}

            //else
            //{
                //Console.WriteLine("Sayı Tek");
            //}
        //}
    }
}
