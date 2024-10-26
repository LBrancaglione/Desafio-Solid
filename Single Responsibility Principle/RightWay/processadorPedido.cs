using System;

namespace SrpRightWay
{
    public class ProcessadorDePedidos
    {
        public string Processar(Pedido pedido)
        {
            return ($"Processando pedido para o cliente {pedido.Cliente} com valor de {pedido.Valor:C}");
        }
    }
}