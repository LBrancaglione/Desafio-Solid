using System;
// Gera relatórios de pedido

namespace SrpRightWay
{
    public class RelatorioPedido
    {
        public string GerarRelatorio(Pedido pedido)
        {
            return $"Pedido ID: {pedido.Id}, Cliente: {pedido.Cliente}, Valor: {pedido.Valor:C}";
        }
    }
}