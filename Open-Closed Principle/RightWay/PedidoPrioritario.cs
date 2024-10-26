public class PedidoPrioritario : IPedido
{
    public double Valor { get; private set; }

    public PedidoPrioritario(double valor)
    {
        Valor = valor;
    }

    public string Processar()
    {
        return $"Processando pedido prioritário com valor de {Valor:C}";
    }
}