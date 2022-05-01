using DigitalBank.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBank.Service.Interfaces
{
    public interface IClienteService
    {
        Task<IEnumerable<Cliente>> BuscarClientes();

        Task<Cliente> BuscarClientePorId(long id);

        Task<IEnumerable<Cliente>> BuscarClientePorNome(string nome);

        Task<Cliente> AdicionarCliente(Cliente novoCliente);

        Task<bool> AdicionarContaParaCliente(Cliente cliente, Conta conta);

        Task<Cliente> AtualizarCliente(long id, Cliente clienteAtualizado);

        Task<bool> RemoverCliente(long id, Cliente clienteRemovido);
    }
}
