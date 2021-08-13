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
    public class ClienteRepository : IClienteRepository
    {
        public AppDbContext _context;

        public ClienteRepository(AppDbContext context)
        {
            _context = context;
        }

        public int Cadastrar(Cliente cliente)
        {
            _context.Add(cliente);
            _context.SaveChanges();
            return cliente.Id;
        }
        public void Editar(Cliente cliente)
        {
            _context.Update(cliente);
            _context.SaveChanges();
        }

        public IEnumerable<Cliente> Listar()
        {
            return _context.Cliente.AsNoTracking().ToList();
        }

        public void Excluir(Cliente cliente)
        {
            _context.Update(cliente);
            _context.SaveChanges();
        }
    }
}
