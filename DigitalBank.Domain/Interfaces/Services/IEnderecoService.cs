using DigitalBank.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBank.Domain.Interfaces.Services
{
    public interface IEnderecoService
    {
        Task<Endereco> BuscarEnderecoPorCep(string cep);
    }
}
