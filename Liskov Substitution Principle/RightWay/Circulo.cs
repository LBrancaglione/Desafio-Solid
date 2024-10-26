public class Circulo : Forma
{
    public double Raio { get; private set; }

    public Circulo(double raio)
    {
        Raio = raio;
    }

    public override double Area()
    {
        return Math.PI * Raio * Raio;
    }

    public override void Alterar(double novoValor)
    {
        Raio = novoValor;
    }
}