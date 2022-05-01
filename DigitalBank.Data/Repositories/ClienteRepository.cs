using DigitalBank.Data.Configurations;
using DigitalBank.Data.Context;
using DigitalBank.Domain.Entities;
using DigitalBank.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public Cliente Adicionar(Cliente novoCliente)
        {
            var cliente = new Cliente(novoCliente.nome, novoCliente.cpf);
            _context.Add(cliente);
            int resultado = _context.SaveChanges();
            if (resultado == 0)
                return null;
            return cliente;
        }

        public bool AdicionarConta(Cliente cliente, Conta conta)
        {
            throw new NotImplementedException();
        }

        public Cliente Atualizar(long id, Cliente clienteAtualizado)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cliente> Buscar()
        {
            var clientes = _context.Clientes;
            if (clientes == null || clientes.ToList().Count == 0)
                return null;
            return clientes;
            //throw new NotImplementedException();
        }

        public Cliente BuscarPorId(long id)
        {
            throw new NotImplementedException();
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
