public class ProcessadorDePedidos
{
    public void Processar(IPedido pedido)
    {
        Console.WriteLine(pedido.Processar());
    }
}