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
    public class PedidoService : IPedidoService
    {
        public IPedidoRepository _pedido;
        public PedidoService(IPedidoRepository pedido)
        {
            _pedido = pedido;
        }

        public int Cadastrar(PedidoViewModel pedido)
        {
            var retorno = _pedido.Cadastrar(pedido.ViewModelToEntity());
            return retorno;
        }      

        public void Editar(PedidoViewModel pedido)
        {
            _pedido.Editar(pedido.ViewModelToEntity());
        }

        public IList<PedidoViewModel> Listar()
        {
            var status = _pedido.Listar().ToList();
            var retorno = new List<PedidoViewModel>();
            foreach (var item in status)
            {
                retorno.Add(item.EntityToViewModel());
            }
            return retorno;
        }

        public void Excluir(PedidoViewModel pedido)
        {
            _pedido.Excluir(pedido.ViewModelToEntity());
        }

        public Pedido GetById(int Id)
        {
            var pedido = _pedido.Listar().Where(s => s.Id == Id).FirstOrDefault();
            return pedido;
        }
    }
}
