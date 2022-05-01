using DigitalBank.Domain.Entities;
using DigitalBank.Domain.Interfaces.Repositories;
using DigitalBank.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBank.Service.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public Cliente AdicionarCliente(Cliente novoCliente)
        {
            Cliente clienteAdicionado = _clienteRepository.Adicionar(novoCliente);
            return clienteAdicionado;
        }

        public bool AdicionarContaParaCliente(Cliente cliente, Conta conta)
        {
            return _clienteRepository.AdicionarConta(cliente, conta);
        }

        public Cliente AtualizarCliente(long id, Cliente clienteAtualizado)
        {
            clienteAtualizado = _clienteRepository.Atualizar(id, clienteAtualizado);
            return clienteAtualizado;
        }

        public IEnumerable<Cliente> BuscarCliente()
        {
            var clientes = _clienteRepository.Buscar();
            if (clientes == null)
                return null;
            return clientes;
            //List<Cliente> clientes = new List<Cliente>();
            //for (int i = 1; i < 6; i++)
            //{
            //    var c = new Cliente("Nome " + i, (i * 100000).ToString());
            //    clientes.Add(c);
            //}
            //return clientes;
        }

        public Cliente BuscarClientePorId(long id)
        {
            var clientes = _clienteRepository.BuscarPorId(id);
            if (clientes == null)
                return null;
            return clientes;
        }

        public IEnumerable<Cliente> BuscarClientePorNome(string nome)
        {
            var clientes = _clienteRepository.BuscarPorNome(nome);
            if (clientes == null)
                return null;
            return clientes;
        }

        public bool RemoverCliente(long id)
        {
            return _clienteRepository.Remover(id);
        }
    }
}
