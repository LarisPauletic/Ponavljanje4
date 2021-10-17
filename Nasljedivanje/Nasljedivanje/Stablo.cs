using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedivanje
{
    class Stablo:Biljka
    {
        bool otpadajuListovi;

        public bool OtpadajuListovi { get => otpadajuListovi; set => otpadajuListovi = value; }
   
        public Stablo(bool otpadajuListovi)
        {
            this.OtpadajuListovi = otpadajuListovi;
        }
    }
}
