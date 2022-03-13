using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList tekSayilar = new ArrayList();
            //ArrayList ciftSayilar = new ArrayList();
            //int ortalama = 0, toplam = 0;
            //Random rnd = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    int sayi = rnd.Next(1, 100);
            //    Console.Write(sayi + "   ");
            //    toplam += sayi;
            //    if (sayi % 2 == 0)
            //    {
            //        ciftSayilar.Add(sayi);
            //    }
            //    else
            //    {
            //        tekSayilar.Add(sayi);
            //    }

            //}
            //Console.WriteLine();
            //Console.WriteLine("=====");
            //ortalama = toplam / 10;

            //Console.WriteLine("Sayıların Ortalaması : {0}", ortalama);
            //Console.WriteLine("Tek Sayıların Adeti : {0}", tekSayilar.Count);
            //Console.WriteLine("Çift Sayıların Adeti : {0}", ciftSayilar.Count);
            //Console.ReadKey();

            List<int> sayilar = new List<int>();
            for (int i = 1; i <= 49; i++)
            {
                sayilar.Add(i);
            }
            for (int x = 1; x <= 6; x++)
            {
                System.Threading.Thread.Sleep(1000); 
                Random rnd = new Random();
                int index = rnd.Next(0, sayilar.Count);
                Console.WriteLine(sayilar[index]);
                sayilar.RemoveAt(index);
            }
            Console.ReadLine();
        }
    }
}
