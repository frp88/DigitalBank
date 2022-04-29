using DigitalBank.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBank.Domain.Interfaces.Services
{
    public interface IClienteService
    {     

        IEnumerable<Cliente> BuscarCliente();

        Cliente BuscarClientePorId(long id);

        IEnumerable<Cliente> BuscarClientePorNome(string nome);

        Cliente AdicionarCliente(Cliente novoCliente);

        bool AdicionarContaParaCliente(Conta conta);

        Cliente AtualizarCliente(long id, Cliente clienteAtualizado);

        bool RemoverCliente(long id);

        // bool temClientesNoDB();

        // void SalvaCincoClientesNoDB();

    }
}
