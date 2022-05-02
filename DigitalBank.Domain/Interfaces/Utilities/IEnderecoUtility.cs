using DigitalBank.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBank.Domain.Interfaces.Utilities
{
    public interface IEnderecoUtility
    {
        Task<Endereco> BuscarPorCep(string cep);

    }
}
