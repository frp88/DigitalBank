using DigitalBank.Domain.Entities;
using System.Threading.Tasks;

namespace DigitalBank.Domain.Interfaces.Utilities
{
    public interface ICpfUtility
    {
        Task<bool> cpfValido(string cpf);
    }
}
