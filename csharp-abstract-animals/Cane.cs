using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Cane : Animale , IMetodianimali
    {
        public void Dormi()
        {
            Console.WriteLine("Cane ZzZ");
        }

        public void Verso()
        {
            Console.WriteLine("bau bau");
        }

        public void Mangia()
        {
            Console.WriteLine("I cani mangiano cibo specifico per cani, che può essere sia cibo secco che umido, formulato per soddisfare le loro esigenze nutrizionali.");
        }
    }
}
