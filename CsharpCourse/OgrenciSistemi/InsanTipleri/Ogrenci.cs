using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciSistemi.InsanTipleri
{
    internal class Ogrenci : Insan
    {
        public string GNO { get; set; }
        public string DersSayisi { get; set; }
        public string Bolum { get; set; }
        
        public Kart.BankaKart OgrenciKarti { get; set; }

}
}
