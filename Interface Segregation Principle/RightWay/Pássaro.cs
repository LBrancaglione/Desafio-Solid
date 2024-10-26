public class Passaro : IAnimal, IFlyable
{
    public void Comer()
    {
        Console.WriteLine("O pássaro está comendo.");
    }

    public void Dormir()
    {
        Console.WriteLine("O pássaro está dormindo.");
    }

    public void Voar()
    {
        Console.WriteLine("O pássaro está voando.");
    }
}