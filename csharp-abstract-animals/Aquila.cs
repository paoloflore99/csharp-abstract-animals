using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Aquila : Animale , IMetodianimali
    {
        public void Dormi()
        {
            Console.WriteLine("Le aquile di solito dormono posate su un ramo alto o su una scogliera, piegando una zampa e nascondendo il becco sotto le ali.");
        }

        public void Verso()
        {
            Console.WriteLine("grido");
        }

        public void Mangia()
        {
            Console.WriteLine("Le aquile si nutrono principalmente di piccoli mammiferi, uccelli, pesci e occasionalmente di carogne.");
        }
    }
}
