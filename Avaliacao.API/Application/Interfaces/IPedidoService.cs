using Avaliacao.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avaliacao.API.Application.Interfaces
{
    public interface IPedidoService
    {
        int Cadastrar(PedidoViewModel pedidoVM);

        void Editar(PedidoViewModel pedidoVM);       

        IList<PedidoViewModel> Listar();

        void Excluir(PedidoViewModel pedidoVM);
        
    }
}
