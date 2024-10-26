public class Quadrado : Forma
{
    public double Lado { get; private set; }

    public Quadrado(double lado)
    {
        Lado = lado;
    }

    public override double Area()
    {
        return Lado * Lado;
    }
}