using DigitalBank.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DigitalBank.Domain.Interfaces.Repositories
{
    public interface IClienteRepository
    {
        Task<IEnumerable<Cliente>> Buscar();

        Task<Cliente> BuscarPorId(long id);

        Task<IEnumerable<Cliente>> BuscarPorNome(string nome);

        Task<bool> Adicionar(Cliente novoCliente);

        Task<bool> AdicionarConta(Cliente cliente, Conta conta);

        Task<bool> Atualizar(long id, Cliente clienteAtualizado);

        Task<bool> Remover(long id, Cliente clienteRemovido);

    }
}
