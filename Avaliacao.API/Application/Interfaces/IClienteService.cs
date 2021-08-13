using Avaliacao.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avaliacao.API.Application.Interfaces
{
    public interface IClienteService
    {
        int Cadastrar(ClienteViewModel clienteVM);

        void Editar(ClienteViewModel clienteVM);       

        IList<ClienteViewModel> Listar();

        void Excluir(ClienteViewModel clienteVM);
    }
}
