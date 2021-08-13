using Avaliacao.API.Application.Interfaces;
using Avaliacao.API.Domain.Entities;
using Avaliacao.API.Domain.Interfaces;
using Avaliacao.API.Mapper;
using Avaliacao.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avaliacao.API.Application.Services
{
    public class ProdutoService : IProdutoService
    {
        public IProdutoRepository _produto;
        public ProdutoService(IProdutoRepository produto)
        {
            _produto = produto;
        }

        public int Cadastrar(ProdutoViewModel produto)
        {
            var retorno = _produto.Cadastrar(produto.ViewModelToEntity());
            return retorno;
        }      

        public void Editar(ProdutoViewModel produto)
        {
            _produto.Editar(produto.ViewModelToEntity());
        }

        public IList<ProdutoViewModel> Listar()
        {
            var status = _produto.Listar().ToList();
            var retorno = new List<ProdutoViewModel>();
            foreach (var item in status)
            {
                retorno.Add(item.EntityToViewModel());
            }
            return retorno;
        }

        public void Excluir(ProdutoViewModel produto)
        {
            _produto.Excluir(produto.ViewModelToEntity());
        }

        public Produto GetById(int Id)
        {
            var produto = _produto.Listar().Where(s => s.Id == Id).FirstOrDefault();
            return produto;
        }
    }
}
