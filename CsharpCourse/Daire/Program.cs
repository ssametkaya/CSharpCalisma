using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daire
{
    class Program
    {
        static void Main(string[] args)
        {
            float yaricap;
            DaireHesap daire = new DaireHesap();

            Console.Write("Çemberin Yarı Çapını Giriniz :");
            yaricap = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Çemberin Alanı :{0:F2}", daire.Alan(yaricap));
            Console.WriteLine("Çemberin Çevresi :{0:F2}", daire.Cevre(yaricap));

            Console.ReadLine();
        }
    }
}
