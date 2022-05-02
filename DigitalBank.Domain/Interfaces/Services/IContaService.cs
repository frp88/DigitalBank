using DigitalBank.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DigitalBank.Domain.Interfaces.Services
{
    public interface IContaService
    {
        Task<IEnumerable<Conta>> BuscarContas();
        Task<Conta> BuscarContaPorId(long id);

        Task<Conta> BuscarContaPorNumero(long numero);

        Task<Conta> AdicionarConta(Conta conta);

        Task<Conta> AtualizarConta(long id, Conta conta);

        Task<bool> RemoverConta(long id);
    }
}
