using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDeneme2
{
    class OgretimGorevlisi : Univesite, IParaHarca
    {
        public int VerilenDersSayısı { get; set; }
        public int Maas  { get; set; }

        public void paraharca(int para)
        {
            Maas = Maas - para;
            Console.WriteLine("Kalan maas " + Maas);
        }
    }
}
