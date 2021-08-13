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
    public class ProdutoRepository : IProdutoRepository
    {
        public AppDbContext _context;

        public ProdutoRepository(AppDbContext context)
        {
            _context = context;
        }

        public int Cadastrar(Produto produto)
        {
            _context.Add(produto);
            _context.SaveChanges();
            return produto.Id;
        }
        public void Editar(Produto produto)
        {
            _context.Update(produto);
            _context.SaveChanges();
        }

        public IEnumerable<Produto> Listar()
        {
            return _context.Produto.AsNoTracking().ToList();
        }

        public void Excluir(Produto produto)
        {
            _context.Update(produto);
            _context.SaveChanges();
        }
    }
}
