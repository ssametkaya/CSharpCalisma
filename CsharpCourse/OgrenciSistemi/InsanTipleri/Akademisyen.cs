using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciSistemi.InsanTipleri
{
    internal class Akademisyen : Insan
    {
        public string VerdigiDersSayisi { get; set; }
        public string Maas { get; set; }
        public string ArabaMarkasi { get; set; }

        public Kart.KrediKart CalisanKarti { get; set; }

    }
}
