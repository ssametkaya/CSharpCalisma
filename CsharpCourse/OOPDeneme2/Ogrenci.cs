using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDeneme2
{
    class Ogrenci : Univesite, IParaHarca
    {
        public string Bolum { get; set; }
        public double GNO { get; set; }
        public int AlınanDersSayısı { get; set; }
        public int Kredi { get; set; }

        public Ogrenci(string _namesurname, string _bolum, double _gno, int _aderssayısı, int _kredi)
        {
            Bolum = _bolum;
            GNO = _gno;
            AlınanDersSayısı = _aderssayısı;
            IsımSoyisim = _namesurname;
            Kredi = _kredi;


        }

        public void paraharca(int para)
        {
            Kredi = Kredi - para;

            Console.WriteLine("Kalan kredi " + Kredi);
        }
    }
}
