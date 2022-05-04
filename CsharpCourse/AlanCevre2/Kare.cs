using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlanCevre2
{
    class Kare:Cokgen,Hesapla
    {
        public int karekenar { get; set; }
        int karealan, karecevre;

        public void AlanHesapla()
        {
            karealan = karekenar * karekenar;

        }

        public void CevreHesapla()
        {
            karecevre = 4 * karekenar;
        }
    }
}
