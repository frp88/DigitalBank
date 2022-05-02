using DigitalBank.Domain.Interfaces.Utilities;
using System;
using System.Threading.Tasks;

namespace DigitalBank.Infrastructure.CrossCutting.Utilities
{
    public class CpfUtility : ICpfUtility
    {
        public CpfUtility() { }

        public Task<bool> cpfValido(string cpf)
        {
            throw new NotImplementedException();
        }
    }
}
