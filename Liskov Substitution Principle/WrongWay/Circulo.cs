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

    public void AlterarRaio(double novoRaio)
    {
        Raio = novoRaio;
    }
}