using DigitalBank.Data.Context;
using DigitalBank.Domain.Entities;
using DigitalBank.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DigitalBank.Data.Repositories
{
    public class ContaRepository : IContaRepository
    {
        private readonly DataContext _context;

        public ContaRepository()
        {
        }

        public ContaRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<bool> Adicionar(Conta conta)
        {
            _context.Add(conta);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Atualizar(Conta conta)
        {
            _context.Update(conta);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<Conta>> Buscar()
        {
            return await _context.Contas
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<Conta> BuscarPorId(long id)
        {
            return await _context.Contas
                  .AsNoTracking()
                 .FirstOrDefaultAsync(c => c.id == id);
        }

        public async Task<Conta> BuscarPorNumero(long numero)
        {
            return await _context.Contas
                  .AsNoTracking()
                 .FirstOrDefaultAsync(c => c.numero == numero);
        }

        public async Task<bool> Remover(Conta conta)
        {
            _context.Remove(conta);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
