using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicalMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Üçgenin bir açı değerini girin:");
            //double aci = Convert.ToDouble(Console.ReadLine());
            //double sin = Math.Sin(aci * Math.PI / 180);
            //double cos = Math.Cos(aci * Math.PI / 180);
            //double tan = Math.Tan(aci * Math.PI / 180);
            //double cot = 1/Math.Tan(aci * Math.PI / 180);

            //Console.WriteLine("Sin:" + sin);
            //Console.WriteLine("Cos:" + cos);
            //Console.WriteLine("Tan:" + tan);
            //Console.WriteLine("Cot:" + cot);

            //Console.ReadKey();


            //Console.WriteLine("Üslü sayının taban değeri:");
            //int taban = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Üslü sayının tavan değeri:");
            //int tavan = Convert.ToInt32(Console.ReadLine());

            //double sonuc = Math.Pow(taban, tavan);
            //Console.WriteLine("Sonuc:" + sonuc);
            //Console.ReadKey();

            //Console.WriteLine("Kilo değerini girin:");
            //double kilo = Convert.ToDouble(Console.ReadLine());

            //double ykilo = Math.Round(kilo);
            //Console.WriteLine("Kilo:" + ykilo);

            //Console.ReadKey();

            //Console.WriteLine("Ortalama değeri girin:");
            //double ort = Convert.ToDouble(Console.ReadLine());
            //double yort = Math.Round(ort);
            //Console.WriteLine("Ortalama:" + yort);

            //Console.ReadKey();


            //Console.WriteLine("Mutlak değeri alınacak sayıyı girin");
            //int sayi = Int32.Parse(Console.ReadLine());

            //int sonuc = Math.Abs(sayi);

            //Console.WriteLine("Sayının Mutlak Değeri: " + sonuc);

            //Console.ReadLine();



            Console.WriteLine("Kesirli değeri girin.");
            double deger = Convert.ToDouble(Console.ReadLine());
            double ydeger = Math.Ceiling(deger);

            Console.WriteLine("deger:"+ ydeger);

            Console.ReadKey();


        }
    }
}
