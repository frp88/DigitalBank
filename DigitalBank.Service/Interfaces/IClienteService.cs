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

        Cliente BuscarClientePorId(long id);

        IEnumerable<Cliente> BuscarClientePorNome(string nome);

        Cliente AdicionarCliente(Cliente novoCliente);

        bool AdicionarContaParaCliente(Cliente cliente, Conta conta);

        Cliente AtualizarCliente(long id, Cliente clienteAtualizado);

        bool RemoverCliente(long id);
    }
}
