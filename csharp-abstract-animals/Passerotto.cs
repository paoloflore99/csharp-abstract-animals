using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Passerotto : Animale, IMetodianimali , IVolano
    {
        public void Dormi()
        {
            Console.WriteLine("Passerotto ZzZ");
        }

        public void Verso()
        {
            Console.WriteLine("cip-cip");
        }

        public void Mangia()
        {
            Console.WriteLine("semi e insetti");
        }

        public void Vola()
        {
            Console.WriteLine("Sto volando!!!");
        }

    }
}
