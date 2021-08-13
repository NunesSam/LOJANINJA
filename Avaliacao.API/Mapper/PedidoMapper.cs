using Avaliacao.API.Domain.Entities;
using Avaliacao.API.Model;

namespace Avaliacao.API.Mapper
{
    public static class PedidoMapper
    {
        public static PedidoViewModel EntityToViewModel(this Pedido pedido)
        {
            if (pedido == null)
            {
                return null;
            }

            var PedidoViewModel = new PedidoViewModel()
            {
                PedidoId = pedido.Id,
                PedidoNumero = pedido.Numero,
                PedidoData = pedido.Data,
                PedidoValor = pedido.Valor,
                PedidoDesconto = pedido.Desconto,
                PedidoValorTotal = pedido.ValorTotal,
                PedidoProduto = pedido.Produto,
                PedidoCliente = pedido.Cliente

            };

            return PedidoViewModel;
        }

        public static Pedido ViewModelToEntity(this PedidoViewModel pedidoVM)
        {
            if (pedidoVM == null)
            {
                return null;
            }

            var pedido = new Pedido()
            {
                Id = pedidoVM.PedidoId,
                Numero = pedidoVM.PedidoId,
                Data = pedidoVM.PedidoData,
                Valor = pedidoVM.PedidoValor,
                Desconto = pedidoVM.PedidoDesconto,
                ValorTotal = pedidoVM.PedidoValorTotal,
                Produto = pedidoVM.PedidoProduto,
                Cliente = pedidoVM.PedidoCliente
            };

            return pedido;
        }
    }
}
