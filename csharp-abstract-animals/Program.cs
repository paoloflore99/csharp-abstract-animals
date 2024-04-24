namespace csharp_abstract_animals
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //------------------ inizio pezzo 1 --------------------------------
            List<IMetodianimali> Animals = new List<IMetodianimali>();
            Animals.Add(new Delfino());
            Animals.Add(new Aquila());
            Animals.Add(new Passerotto());
            Animals.Add(new Cane());
            

            foreach (var caratteristiche in Animals)
            {
                caratteristiche.Dormi();
                caratteristiche.Verso();
                caratteristiche.Mangia();
            }

            //------------------ inizio pezzo 2 ---------------------------------
            List<IVolano> AnimaliVolano = new List<IVolano>();
            AnimaliVolano.Add(new Aquila());
            AnimaliVolano.Add(new Passerotto());
            foreach (var volano in AnimaliVolano)
            {
                volano.FaiVolare();
            }

            List<INuotano> AnimaliNuotano = new List<INuotano>();
            AnimaliNuotano.Add(new Delfino());
            foreach(var nuotano in AnimaliNuotano)
            {
                nuotano.FaiNuotare();
            }





        }
    }
}
