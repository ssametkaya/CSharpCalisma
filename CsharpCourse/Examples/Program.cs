using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    class Program
    {
        //private static void AlanHesapla()
        //{
        //Console.Write("kısa kenarı");
        //int kk = Convert.ToInt32(Console.ReadLine());
        //Console.Write("uzun kenarı");
        //int uk = Convert.ToInt32(Console.ReadLine());
        //int alan = kk * uk;
        //Console.WriteLine("Alan = {0}", alan);
        //}

        //static void Main(string[] args)
        //{
        //AlanHesapla();
        //Console.ReadKey();
        //}



        //static void Main()
        //{
        //int sayi;
        //int sonuc = 1;
        //for (int i = 1; i <= 10; i++)
        //{
        //Console.WriteLine("{0}.Sayıyı Giriniz;", i);
        //sayi = Convert.ToInt32(Console.ReadLine());
        //if ((sayi > 0) && (sayi % 2 == 1))
        //{
        //sonuc *= sayi;
        //}
        //Console.WriteLine();
        //}

        //Console.WriteLine("Pozitif ve tek sayıların çarpımı : " + sonuc);
        //Console.ReadKey();
        //}


        //static void Main(string[] args)
        //{
        //    string isim;
        //    Console.Write("isminiz nedir?");
        //    isim = Console.ReadLine();
        //    int i;
        //    for (i = 1; i <= 10; i++)
        //    {
        //        Console.WriteLine("{0} : {1}", i, isim);
        //    }
        //    Console.ReadKey();
        //}

        //static void Main(string[] args)
        //{

        //    for (int i = 1; i <= 100; i++)
        //    {
        //        if (i % 3 == 0 && i % 5 == 0)
        //        { Console.WriteLine(i); }
        //    }
        //    Console.ReadKey();
        //}


        static void Main(string[] args)
        {
            Console.Write("1. Sayıyı girin:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayıyı girin:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            for (int i = sayi1; i <= sayi2; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }

    }

}


