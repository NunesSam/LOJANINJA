using Avaliacao.API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avaliacao.API.Model
{
    public class PedidoViewModel
    {
        public int PedidoId { get; set; }
        public int PedidoNumero { get; set; }
        public DateTime PedidoData { get; set; }
        public double PedidoValor { get; set; }
        public double PedidoDesconto { get; set; }
        public double PedidoValorTotal { get; set; }
        public Produto PedidoProduto { get; set; }
        public Cliente PedidoCliente { get; set; }

    }
}
