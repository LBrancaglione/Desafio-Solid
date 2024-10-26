using System;

public class Pedido
{
    public int Id { get; set; }
    public string Cliente { get; set; }
    public double Valor { get; set; }

    // Este método processa o pedido
    public void ProcessarPedido()
    {
        // Lógica de negócios para processar o pedido
        Console.WriteLine($"Processando pedido para o cliente {Cliente} com valor de {Valor:C}");
    }

    // Este método grava o pedido no banco de dados
    public void SalvarPedidoNoBanco()
    {
        // Simula a gravação no banco de dados
        Console.WriteLine("Pedido salvo no banco de dados.");
    }

    // Este método formata o pedido para exibição
    public string GerarRelatorioPedido()
    {
        return $"Pedido ID: {Id}, Cliente: {Cliente}, Valor: {Valor:C}";
    }
}

public class Program
{
    public static void Main()
    {
        Pedido pedido = new Pedido
        {
            Id = 1,
            Cliente = "Leonardo",
            Valor = 500.00
        };

        pedido.ProcessarPedido();
        pedido.SalvarPedidoNoBanco();
        Console.WriteLine(pedido.GerarRelatorioPedido());
    }
}