using DigitalBank.Domain.Entities;
using DigitalBank.Domain.Interfaces.Repositories;
using DigitalBank.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<Cliente> AdicionarCliente(Cliente novoCliente)
        {
            var clienteAdicionado = await _clienteRepository.Adicionar(novoCliente);
            if (!clienteAdicionado)
                throw new Exception("Falha ao cadastrar o cliente");
            return novoCliente;
        }

        public async Task<bool> AdicionarContaParaCliente(Cliente cliente, Conta conta)
        {
            return await _clienteRepository.AdicionarConta(cliente, conta);
        }

        public async Task<Cliente> AtualizarCliente(long id, Cliente clienteAtualizado)
        {
            //clienteAtualizado = _clienteRepository.Atualizar(id, clienteAtualizado);
            //return clienteAtualizado;
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Cliente>> BuscarClientes()
        {
            var clientes = await _clienteRepository.Buscar();
            if (clientes == null || clientes.ToList().Count == 0)
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

        public async Task<Cliente> BuscarClientePorId(long id)
        {
            var cliente = await _clienteRepository.BuscarPorId(id);
            return cliente;
        }

        public async Task<IEnumerable<Cliente>> BuscarClientePorNome(string nome)
        {
            var clientes = await _clienteRepository.BuscarPorNome(nome);
            if (clientes == null)
                return null;
            return clientes;
        }

        public async Task<bool> RemoverCliente(long id, Cliente clienteRemovido)
        {
            return await _clienteRepository.Remover(id, clienteRemovido);
        }
    }
}
