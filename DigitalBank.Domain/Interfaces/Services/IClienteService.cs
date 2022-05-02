using DigitalBank.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DigitalBank.Domain.Interfaces.Services
{
    public interface IClienteService
    {
        Task<IEnumerable<Cliente>> BuscarClientes();

        Task<Cliente> BuscarClientePorId(long id);

        Task<IEnumerable<Cliente>> BuscarClientesPorNome(string nome);

        Task<Cliente> AdicionarCliente(Cliente novoCliente);

        Task<bool> AdicionarContaParaCliente(Cliente cliente, Conta novaConta);

        Task<Cliente> AtualizarCliente(long id, Cliente clienteAtualizado);

        Task<bool> RemoverCliente(long id);
    }
}
