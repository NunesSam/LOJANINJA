using Avaliacao.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avaliacao.API.Application.Interfaces
{
    public interface IProdutoService
    {
        int Cadastrar(ProdutoViewModel produtoVM);

        void Editar(ProdutoViewModel produtoVM);       

        IList<ProdutoViewModel> Listar();

        void Excluir(ProdutoViewModel produtoVM);

    }
}
