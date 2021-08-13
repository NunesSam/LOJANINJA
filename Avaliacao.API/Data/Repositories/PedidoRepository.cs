using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Avaliacao.API.Data.Context;
using Avaliacao.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Avaliacao.API.Domain.Interfaces;

namespace Avaliacao.API.Data.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        public AppDbContext _context;

        public PedidoRepository(AppDbContext context)
        {
            _context = context;
        }

        public int Cadastrar(Pedido pedido)
        {
            _context.Add(pedido);
            _context.SaveChanges();
            return pedido.Id;
        }
        public void Editar(Pedido pedido)
        {
            _context.Update(pedido);
            _context.SaveChanges();
        }

        public IEnumerable<Pedido> Listar()
        {
            return _context.Pedido.AsNoTracking().ToList();
        }

        public void Excluir(Pedido pedido)
        {
            _context.Update(pedido);
            _context.SaveChanges();
        }
    }
}
