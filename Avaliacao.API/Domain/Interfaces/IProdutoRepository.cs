using Avaliacao.API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avaliacao.API.Domain.Interfaces
{
    public interface IProdutoRepository
    {
        int Cadastrar(Produto produto);
        void Editar(Produto produto);
        IEnumerable<Produto> Listar();
        void Excluir(Produto produto);
    }
}
