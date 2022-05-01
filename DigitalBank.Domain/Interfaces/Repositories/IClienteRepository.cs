using DigitalBank.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBank.Domain.Interfaces.Repositories
{
    public interface IClienteRepository
    {
        Task<IEnumerable<Cliente>> Buscar();

        Cliente BuscarPorId(long id);

        IEnumerable<Cliente> BuscarPorNome(string nome);

        bool Adicionar(Cliente novoCliente);

        bool AdicionarConta(Cliente cliente, Conta conta);

        bool Atualizar(long id, Cliente clienteAtualizado);

        bool Remover(long id);

    }
}
