using DigitalBank.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DigitalBank.Domain.Interfaces.Repositories
{
    public interface IContaRepository
    {
        Task<IEnumerable<Conta>> Buscar();

        Task<Conta> BuscarPorId(long id);

        Task<Conta> BuscarPorNumero(long numero);

        Task<bool> Adicionar(Conta conta);

        Task<bool> Atualizar(Conta conta);

        Task<bool> Remover(Conta conta);

    }
}
