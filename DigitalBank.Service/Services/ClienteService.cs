using DigitalBank.Domain.Entities;
using DigitalBank.Domain.Interfaces.Repositories;
using DigitalBank.Domain.Interfaces.Services;
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

        public async Task<Cliente> AdicionarCliente(Cliente cliente)
        {
            var adicaoOk = await _clienteRepository.Adicionar(cliente);
            if (adicaoOk == false)
                throw new Exception("Falha ao cadastrar o cliente.");
            return cliente;
        }

        public async Task<bool> AdicionarContaParaCliente(Cliente cliente, Conta conta)
        {
            return await _clienteRepository.AdicionarConta(cliente, conta);
        }

        public async Task<Cliente> AtualizarCliente(long id, Cliente cliente)
        {
            if (await _clienteRepository.BuscarPorId(id) == null)
                return null;

            var atualizacaoOk = await _clienteRepository.Atualizar(cliente);
            if (!atualizacaoOk)
                return null;

            return cliente;
        }

        public async Task<IEnumerable<Cliente>> BuscarClientes()
        {
            var clientes = await _clienteRepository.Buscar();
            if (clientes == null || clientes.ToList().Count == 0)
                return null;
            return clientes;
        }

        public async Task<Cliente> BuscarClientePorId(long id)
        {
            var cliente = await _clienteRepository.BuscarPorId(id);
            return cliente;
        }

        public async Task<IEnumerable<Cliente>> BuscarClientesPorNome(string nome)
        {
            var clientes = await _clienteRepository.BuscarPorNome(nome);
            return clientes;
        }

        public async Task<bool> RemoverCliente(long id)
        {
            var cliente = await _clienteRepository.BuscarPorId(id);
            if (cliente == null)
                return false;

            return await _clienteRepository.Remover(cliente);
        }
    }
}
