using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Passerotto : Animale, IMetodianimali
    {
        public void Dormi()
        {
            Console.WriteLine("I passeri giovani dormono in nidi protetti o tra i cespugli durante la notte.");
        }

        public void Verso()
        {
            Console.WriteLine("cip-cip");
        }

        public void Mangia()
        {
            Console.WriteLine("semi e insetti");
        }
    }
}
