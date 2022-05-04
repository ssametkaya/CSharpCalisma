using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlanCevre2
{
    class Ucgen:Cokgen,Hesapla
    {
        public int yükseklik { get; set; }
        public int taban { get; set; }


        
        public int kenar1 { get; set; }
        public int kenar2 { get; set; }
        public int kenar3 { get; set; }

        int ucgencevre, ucgenalan;

        public void AlanHesapla()
        {
            ucgenalan = (yükseklik * taban) / 2;
        }

        public void CevreHesapla()
        {
            ucgencevre = kenar1 + kenar2 + kenar3;
        }
    }
}
