public class Cachorro : IAnimal
{
    public void Comer()
    {
        // Implementação do método Comer
        Console.WriteLine("O cachorro está comendo.");
    }

    public void Dormir()
    {
        // Implementação do método Dormir
        Console.WriteLine("O cachorro está dormindo.");
    }

    public void Voar()
    {
        // Violação: um cachorro não pode voar
        throw new NotImplementedException("Cachorros não podem voar.");
    }
}