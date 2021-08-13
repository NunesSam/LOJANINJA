using Avaliacao.API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avaliacao.API.Domain.Interfaces
{
    public interface IClienteRepository
    {
        int Cadastrar(Cliente cliente);
        void Editar(Cliente cliente);
        IEnumerable<Cliente> Listar();
        void Excluir(Cliente cliente);
    }
}
