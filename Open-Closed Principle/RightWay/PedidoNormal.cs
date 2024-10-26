public class PedidoNormal : IPedido
{
    public double Valor { get; private set; }

    public PedidoNormal(double valor)
    {
        Valor = valor;
    }

    public string Processar()
    {
        return $"Processando pedido normal com valor de {Valor:C}";
    }
}