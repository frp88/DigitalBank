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
        IEnumerable<Cliente> Buscar();

        Cliente BuscarPorId(long id);

        IEnumerable<Cliente> BuscarPorNome(string nome);

        Cliente Adicionar(Cliente novoCliente);

        bool AdicionarConta(Conta conta);

        Cliente Atualizar(long id, Cliente clienteAtualizado);

        bool Remover(long id);

        // bool temClientesNoDB();

        // void SalvaCincoClientesNoDB();

    }
}
