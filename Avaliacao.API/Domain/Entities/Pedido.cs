using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avaliacao.API.Domain.Entities
{
    public class Pedido
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public DateTime Data { get; set; }
        public double Valor { get; set; }
        public double Desconto { get; set; }
        public double ValorTotal { get; set; }
        public Produto Produto { get; set; }
        public Cliente Cliente { get; set; }
    }
}
