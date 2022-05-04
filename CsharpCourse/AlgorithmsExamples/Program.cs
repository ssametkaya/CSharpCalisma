using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Metin giriniz:");
            //string metin = Console.ReadLine();

            //Console.WriteLine("Metinin ters hali");
            //for (int i = metin.Length-1; i>=0; i--)
            //{
            //    Console.Write(metin[i]);
            //}

            //Console.ReadKey();

            //Tek mi çift mi
            //int x;
            //Console.WriteLine("Sayı giriniz:");
            //x = Convert.ToInt32(Console.ReadLine());

            //if (x%2==0)
            //{
            //    Console.WriteLine("sayı çifttir.");
            //}
            //else
            //{
            //    Console.WriteLine("sayı tektir.");
            //}


            //Console.ReadKey();

            //Karenin alanı ve cevresi
            //int x,alan,cevre;
            //Console.Write("Karenin kenar uzunluğunu giriniz: ");
            //x = Convert.ToInt32(Console.ReadLine());


            //alan = x*x;
            //cevre = 4 * x;
            //Console.WriteLine("Karenin alanı=" +alan);
            //Console.WriteLine("Karenin cevresi=" + cevre);

            //Console.ReadKey();

            //dikdörtgen alan çevre
            //int kısakenar, uzunkenar, alan, cevre;

            //Console.Write("Kısa kenarı giriniz:");
            //kısakenar = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Uzun kenarı giriniz:");
            //uzunkenar = Convert.ToInt32(Console.ReadLine());

            //if (kısakenar > uzunkenar) 
            //{
            //    Console.WriteLine("Hatalı veriler girdiniz");
            //}

            //else

            //{
            //    cevre = 2 * (kısakenar + uzunkenar);
            //    alan = kısakenar * uzunkenar;



            //    Console.WriteLine("Dikdörtgenin cevresi: " + cevre);
            //    Console.WriteLine("Dikdörtgenin alanı: " + alan);
            //}
            //Console.ReadLine();

            //kmyi mile çevirme
            //double km, mil;

            //Console.Write("Mile çevirilecek km değerini giriniz:");

            //km = Convert.ToDouble(Console.ReadLine());

            //mil = km * 0.62137;

            //Console.WriteLine("Mil değeri: " + mil);

            //Console.ReadLine();

            //int s1, s2, s3, buyuk, kucuk;

            //Console.Write("Sayı 1'i giriniz: ");
            //s1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Sayı 2'i giriniz: ");
            //s2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Sayı 3'i giriniz: ");
            //s3 = Convert.ToInt32(Console.ReadLine());

            //if (s1 > s2 && s1 > s3) 
            //{
            //    buyuk = s1;
            //}
            //else if (s2>s3)
            //{
            //    buyuk = s2;
            //}
            //else
            //{
            //    buyuk = s3;
            //}

            //if (s1 < s2 && s1 < s3)
            //{
            //    kucuk = s1;
            //}
            //else if (s2 < s3) 
            //{
            //    kucuk = s2;
            //}
            //else
            //{
            //    kucuk = s3;
            //}

            //Console.WriteLine("Büyük ve küçük sayının toplamı {0}", buyuk + kucuk);

            //Console.WriteLine("Büyük ve küçük sayının farkı {0}", buyuk - kucuk);

            //Console.ReadLine();


            // 0 100 arası 3 ve 5e bölünenler
            //for (int i = 1; i < 100; i++)
            //{
            //    if (i % 3 == 0 && i %5 == 0) 
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.ReadKey();


            //iki sayı arasındaki sayıları belirli bir adım miktarı ile toplama

            //int baslangic, son, adim, toplam=0;

            //Console.WriteLine("Başlangıç degerini giriniz: ");
            //baslangic = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Son değeri giriniz:");
            //son = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Adım miktarı: ");
            //adim = Convert.ToInt32(Console.ReadLine());

            //for (int i = baslangic; i <= son; i+=adim)
            //{
            //    toplam += i;
            //}

            //Console.WriteLine("Toplam= " + toplam);

            //Console.ReadLine();

            // dizinin elemanlarını toplamı
            //int[] dizi = { 0, 6, 8, 31, 312 };
            //int toplam = 0;

            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    toplam += dizi[i];
            //}

            //Console.WriteLine(toplam);
            //Console.ReadKey();



            //Console.WriteLine("1. sayıyı giriniz");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2.sayıyı giriniz");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //double sonuc=Math.Pow(sayi1, 2) + Math.Pow(sayi2,2) ;

            //Console.WriteLine(sonuc);

            //Console.Read();

            //double toplam = 1;
            //for (int i = 1; i <= 10; i++)
            //{
            //    toplam += Math.Pow(i, 3);
            //}

            //Console.WriteLine(toplam);
            //Console.ReadKey();

            //// Yas hesaplama
            //Console.WriteLine("Doğum Tarihinizi giriniz: ");

            //DateTime dogumTarihi = Convert.ToDateTime(Console.ReadLine());

            //TimeSpan yas = DateTime.Now - dogumTarihi;

            //Console.WriteLine(yas.Days / 365);



            //Console.ReadKey();

            //girilen sayının faktöriyeli
            //Console.WriteLine("Sayı giriniz:");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int faktöriyel=1;
            //for (int i = sayi; i>0; i--)
            //{
            //    faktöriyel *= i;
            //}

            //Console.WriteLine(faktöriyel);
            //Console.ReadLine();


            Console.WriteLine("Birinici sayıyı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int carpim = 0;
            for (int i = 0; i < sayi2; i++)
            {
                carpim += sayi1;
            }

            Console.WriteLine(carpim);

            Console.ReadKey();
        }
    }
}
