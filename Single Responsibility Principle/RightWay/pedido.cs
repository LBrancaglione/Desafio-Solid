using System;

// Serve apenas para representar os dados de um pedido.
namespace SrpRightWay
{
    public class Pedido
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public double Valor { get; set; }

    }
}