using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDeneme2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci samet = new Ogrenci("samet", "elhab", 2.7, 12, 500);

            Ogrenci ahmet = new Ogrenci("ahmet", "bilgisayar", 3.1, 15,10000);

            samet.paraharca(450);

            ahmet.paraharca(2000);

            if (samet.Kredi<100)
            {
                Console.WriteLine("Paran az kaldı nakitavansa gireceksin neredeyse sakin! samet");
            }


            if (ahmet.Kredi > 5000)
            {
                Console.WriteLine("Daha çok var harcayabilirsin ahmet");
            }

            if (samet.GNO<3)
            {
                Console.WriteLine("Ortalamanı 3 üstüne cıkar samet");
            }


            Console.Read();



        }
    }
}
