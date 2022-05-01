using DigitalBank.Data.Context;
using DigitalBank.Domain.Entities;
using DigitalBank.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalBank.Data.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly DataContext _context;

        public ClienteRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<bool> Adicionar(Cliente cliente)
        {
            _context.Add(cliente);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> AdicionarConta(Cliente cliente, Conta conta)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Atualizar(Cliente cliente)
        {
            _context.Update(cliente);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<Cliente>> Buscar()
        {
            return await _context.Clientes
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<Cliente> BuscarPorId(long id)
        {
            return await _context.Clientes
                 .AsNoTracking()
                .FirstOrDefaultAsync(c => c.id == id);
        }

        public async Task<IEnumerable<Cliente>> BuscarPorNome(string nome)
        {
            return await _context.Clientes
               .AsNoTracking()
               .Where(c => c.nome.Contains(nome))
               .ToListAsync();
        }

        public async Task<bool> Remover(Cliente cliente)
        {
            _context.Remove(cliente);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
