using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciSistemi.InsanTipleri
{
    internal class FehmiDayi : Insan
    {

        public string OsiloskobSayisi { get; set; }
        public string PahaliProbMarkasi { get; set; }
        public string LaboratuvarIsmi { get; set; }

        public Kart.KrediKart CalisanKarti { get; set; }

    }
}
