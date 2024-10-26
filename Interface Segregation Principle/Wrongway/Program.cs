using System;

class Program
{
    static void Main()
    {
        IAnimal passaro = new Passaro();
        passaro.Comer();
        passaro.Dormir();
        passaro.Voar();

        IAnimal cachorro = new Cachorro();
        cachorro.Comer();
        cachorro.Dormir();
        cachorro.Voar(); // Mas cachorro não é capaz de voar, não é mesmo ?
    }
}