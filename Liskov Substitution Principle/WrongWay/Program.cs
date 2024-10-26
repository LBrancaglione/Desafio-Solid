using System;

class Program
{
    static void Main()
    {
        Forma quadrado = new Quadrado(5);
        Forma circulo = new Circulo(3);

        Console.WriteLine($"Área do quadrado: {quadrado.Area()}");
        Console.WriteLine($"Área do círculo: {circulo.Area()}");

        // Aqui é a violação do LSP
        AlterarForma(circulo);
        Console.WriteLine($"Área do círculo após alteração: {circulo.Area()}");
    }

    static void AlterarForma(Forma forma)
    {
        // Tentamos alterar o raio de um círculo
        if (forma is Circulo circulo)
        {
            circulo.AlterarRaio(5);
        }
        else
        {
            // Se tentarmos usar uma forma diferente, não teremos o mesmo comportamento
            throw new InvalidOperationException("Forma não suportada para alteração.");
        }
    }
}