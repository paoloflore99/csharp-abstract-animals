using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Aquila : Animale , IMetodianimali , IVolano
    {
        public void Dormi()
        {
            Console.WriteLine("Aquila ZzZ");
        }

        public void Verso()
        {
            Console.WriteLine("grido");
        }

        public void Mangia()
        {
            Console.WriteLine("Le aquile si nutrono principalmente di piccoli mammiferi, uccelli, pesci e occasionalmente di carogne.");
        }

        //------------------ inizio pezzo 2 ---------------------------------
        public void FaiVolare()
        {
            Console.WriteLine("Sto volando!!!");
        }
    }
    
}
