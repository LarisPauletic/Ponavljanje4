using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedivanje
{
    class Program
    {
        static void Main(string[] args)
        {
            Bijelogoricno Hrast = new Bijelogoricno(true);
            Crnogoricno Bor = new Crnogoricno(false);

            Console.WriteLine($"Pada li hrastu lišće? {Hrast.OtpadajuListovi}");
            Console.WriteLine();
            Console.WriteLine($"Pada li boru lišće? {Bor.OtpadajuListovi}");

            Console.ReadKey();
        }
    }
}
