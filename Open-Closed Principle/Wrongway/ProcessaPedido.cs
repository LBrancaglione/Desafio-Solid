public class ProcessadorDePedidos
{
    public void Processar(Pedido pedido)
    {
        if (pedido.Tipo == "Normal")
        {
            Console.WriteLine($"Processando pedido normal com valor de {pedido.Valor:C}");
        }
        else if (pedido.Tipo == "Urgente")
        {
            Console.WriteLine($"Processando pedido urgente com valor de {pedido.Valor:C}");
        }
        else if (pedido.Tipo == "Prioritário")
        {
            Console.WriteLine($"Processando pedido prioritário com valor de {pedido.Valor:C}");
        }
        else
        {
            Console.WriteLine("Tipo de pedido desconhecido.");
        }
    }
}