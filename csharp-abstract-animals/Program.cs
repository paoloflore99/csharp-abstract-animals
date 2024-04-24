namespace csharp_abstract_animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IMetodianimali> Animals = new List<IMetodianimali>();
            Animals.Add(new Delfino());
            Animals.Add(new Aquila());
            Animals.Add(new Passerotto());
            Animals.Add(new Cane());

            foreach (var caratteristiche in Animals)
            {
                caratteristiche.Dormi();
            }

            
        }
    }
}
