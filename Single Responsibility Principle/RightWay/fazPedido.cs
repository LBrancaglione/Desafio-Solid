using System; 
using SrpRightWay;

    class fazPedido
    {
        public static void Main()
        {
            Pedido pedido = new Pedido
            {
                Id = 1,
                Cliente = "Leonardo",
                Valor = 500.00
            };

            ProcessadorDePedidos processador = new ProcessadorDePedidos();
            RepositorioPedido repositorio = new RepositorioPedido();
            RelatorioPedido relatorio = new RelatorioPedido();

            processador.Processar(pedido);
            repositorio.Salvar(pedido);
            Console.WriteLine(processador.Processar(pedido));
            Console.WriteLine(repositorio.Salvar(pedido));
            Console.WriteLine(relatorio.GerarRelatorio(pedido));
        }
    }