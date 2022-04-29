using DigitalBank.Domain.Entities;
using DigitalBank.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBank.Domain.Services
{
    internal class ClienteService : IClienteService
    {
        public ClienteService()
        {

        }

        public Cliente AdicionarCliente(Cliente novoCliente)
        {
            throw new NotImplementedException();
        }

        public bool AdicionarContaParaCliente(Conta conta)
        {
            throw new NotImplementedException();
        }

        public Cliente AtualizarCliente(long id, Cliente clienteAtualizado)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cliente> BuscarCliente()
        {
            throw new NotImplementedException();
        }

        public Cliente BuscarClientePorId(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cliente> BuscarClientePorNome(string nome)
        {
            throw new NotImplementedException();
        }

        public bool RemoverCliente(long id)
        {
            throw new NotImplementedException();
        }
    }
}
