using Avaliacao.API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avaliacao.API.Domain.Interfaces
{
    public interface IPedidoRepository
    {
        int Cadastrar(Pedido pedido);
        void Editar(Pedido pedido);
        IEnumerable<Pedido> Listar();
        void Excluir(Pedido pedido);
    }
}
