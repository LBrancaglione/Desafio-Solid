public class PedidoUrgente : IPedido
{
    public double Valor { get; private set; }

    public PedidoUrgente(double valor)
    {
        Valor = valor;
    }

    public string Processar()
    {
        return $"Processando pedido urgente com valor de {Valor:C}";
    }
}