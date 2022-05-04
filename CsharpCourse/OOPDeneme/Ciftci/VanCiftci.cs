using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDeneme
{
    class VanCiftci : Ciftci, IKes
    {
        public int koyun { get; set; }


        private string name;
        public VanCiftci(string _name)
        {
            name = _name;
        }

        public void Kesim(int kesilen)
        {
            koyun = koyun - kesilen;

            Console.WriteLine("Kesim sonrası koyun sayısı "+koyun);

        }
    }
}
