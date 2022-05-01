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

        public bool Adicionar(Cliente novoCliente)
        {
            _context.Add(novoCliente);
            var resultado = _context.SaveChanges();
            return (resultado == 0 ? false : true);
        }

        public bool AdicionarConta(Cliente cliente, Conta conta)
        {
            throw new NotImplementedException();
        }

        public bool Atualizar(long id, Cliente clienteAtualizado)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Cliente>> Buscar()
        {
            return await _context.Clientes
                .AsNoTracking()
                .ToListAsync();
        }

        public Cliente BuscarPorId(long id)
        {
            var cliente =  _context.Clientes.FirstOrDefault(
                       c => c.id == id);
            return cliente;
        }

        public IEnumerable<Cliente> BuscarPorNome(string nome)
        {
            throw new NotImplementedException();
        }

        public bool Remover(long id)
        {
            throw new NotImplementedException();
        }
    }
}
