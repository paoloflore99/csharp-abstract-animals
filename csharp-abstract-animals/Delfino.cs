using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Delfino :Animale , IMetodianimali
    {
        public void Dormi()
        {
            Console.WriteLine("Il delfino dorme emisfero cerebrale alla volta.");
        }

        public void Verso()
        {
           Console.WriteLine("squeak o click");
        }

        public void Mangia()
        {
            Console.WriteLine("Il delfino si nutre principalmente di pesci, calamari e altri piccoli organismi marini.");
        }

    }
}
