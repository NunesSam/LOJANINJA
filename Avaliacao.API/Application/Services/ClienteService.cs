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
    public class ClienteService : IClienteService
    {
        public IClienteRepository _cliente;
        public ClienteService(IClienteRepository cliente)
        {
            _cliente = cliente;
        }

        public int Cadastrar(ClienteViewModel cliente)
        {
            var retorno = _cliente.Cadastrar(cliente.ViewModelToEntity());
            return retorno;
        }      

        public void Editar(ClienteViewModel cliente)
        {
            _cliente.Editar(cliente.ViewModelToEntity());
        }

        public IList<ClienteViewModel> Listar()
        {
            var status = _cliente.Listar().ToList();
            var retorno = new List<ClienteViewModel>();
            foreach (var item in status)
            {
                retorno.Add(item.EntityToViewModel());
            }
            return retorno;
        }

        public void Excluir(ClienteViewModel cliente)
        {
            _cliente.Excluir(cliente.ViewModelToEntity());
        }

        public Cliente GetById(int Id)
        {
            var cliente = _cliente.Listar().Where(s => s.Id == Id).FirstOrDefault();
            return cliente;
        }
    }
}
