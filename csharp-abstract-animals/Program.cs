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
            //------------------ fine pezzo 1 -----------------------------------




            //------------------ inizio pezzo 2 ---------------------------------
        }
    }
}
