using System;

class Program
{
    static void Main()
    {
        IAnimal passaro = new Passaro();
        passaro.Comer();
        passaro.Dormir();

        IFlyable voador = passaro as IFlyable;
        voador?.Voar(); // Verifica se é voador antes de chamar o método

        IAnimal cachorro = new Cachorro();
        cachorro.Comer();
        cachorro.Dormir();

        // Não há mais problemas com o método Voar, pois o cachorro não implementa IFlyable
    }
}