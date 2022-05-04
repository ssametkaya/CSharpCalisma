using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDeneme
{
    class Program
    {
        static void Main(string[] args)
        {
            VanCiftci samet = new VanCiftci("Samet");
            samet.koyun = 10;
            samet.Kesim(4);

            samet.kopek = "karabas";


            if (samet.kopek=="karabas")
            {
                Console.WriteLine("Karabas gel olm gel  ");
            }

            
            Console.Read();
        }
    }
}
