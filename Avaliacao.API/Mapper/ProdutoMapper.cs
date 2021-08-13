using Avaliacao.API.Domain.Entities;
using Avaliacao.API.Model;

namespace Avaliacao.API.Mapper
{
    public static class ProdutoMapper
    {
        public static ProdutoViewModel EntityToViewModel(this Produto produto)
        {
            if (produto == null)
            {
                return null;
            }
             
            var ProdutoViewModel = new ProdutoViewModel()
            {
                
                ProdutoId = produto.Id,
                ProdutoDescricao = produto.Descricao,
                ProdutoValor = produto.Valor

            };

            return ProdutoViewModel;
        }

        public static Produto ViewModelToEntity(this ProdutoViewModel produtoVM)
        {
            if (produtoVM == null)
            {
                return null;
            }

            var produto = new Produto()
            {
                Id = produtoVM.ProdutoId,
                Descricao = produtoVM.ProdutoDescricao,
                Valor = produtoVM.ProdutoValor
            };

            return produto;
        }
    }
}
