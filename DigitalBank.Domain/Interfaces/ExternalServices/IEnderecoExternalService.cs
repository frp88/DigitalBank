using DigitalBank.Domain.Entities;
using System.Threading.Tasks;

namespace DigitalBank.Domain.Interfaces.ExternalServices
{
    public interface IEnderecoExternalService
    {
        Task<Endereco> BuscarPorCep(string cep);

    }
}
