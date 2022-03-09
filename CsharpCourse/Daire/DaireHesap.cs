using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daire
{
    class DaireHesap
    {
        public float Alan(float ycap)
        {
            return Convert.ToSingle(Math.PI * ycap * ycap);
        }

        public float Cevre(float ycap)
        {
            return Convert.ToSingle(2 * Math.PI * ycap);
        }

    }
}
