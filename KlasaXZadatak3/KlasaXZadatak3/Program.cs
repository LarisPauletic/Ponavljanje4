using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasaXZadatak3
{
    class Program
    {
        static void Main(string[] args)
        {
            KlasaX x = new KlasaX();
            for (x.indeks = 0; x.indeks < 100; x.indeks++)
            {
                x.niz[x.indeks] = x.indeks + 1;
            }
            Console.WriteLine($"Uneseno je prvih 100 brojeva, a 50 indeks je {x.niz[50]}");
            Console.ReadKey();
        }
    }
}
