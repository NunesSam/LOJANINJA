using Avaliacao.API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avaliacao.API.Model
{
    public class ProdutoViewModel
    {
        public int ProdutoId { get; set; }
        public string ProdutoDescricao { get; set; }
        public double ProdutoValor { get; set; }

    }
}
