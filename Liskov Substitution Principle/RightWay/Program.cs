using System;

class Program
{
    static void Main()
    {
        Forma quadrado = new Quadrado(5);
        Forma circulo = new Circulo(3);

        Console.WriteLine($"Área do quadrado: {quadrado.Area()}");
        Console.WriteLine($"Área do círculo: {circulo.Area()}");

        // Agora podemos alterar o lado do quadrado ou o raio do círculo
        AlterarForma(quadrado, 10);
        AlterarForma(circulo, 5);

        Console.WriteLine($"Área do quadrado após alteração: {quadrado.Area()}");
        Console.WriteLine($"Área do círculo após alteração: {circulo.Area()}");
    }

    static void AlterarForma(Forma forma, double novoValor)
    {
        forma.Alterar(novoValor);
    }
}