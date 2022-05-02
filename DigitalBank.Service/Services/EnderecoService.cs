using DigitalBank.Domain.Entities;
using DigitalBank.Domain.Interfaces.Services;
using DigitalBank.Domain.Interfaces.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBank.Service.Services
{

    public class EnderecoService: IEnderecoService
    {
        private readonly IEnderecoUtility _enderecoUtility;

        public EnderecoService(IEnderecoUtility enderecoUtility)
        {
            _enderecoUtility = enderecoUtility;
        }

    public async Task<Endereco> BuscarEnderecoPorCep(string cep)
        {
            var endereco = await _enderecoUtility.BuscarPorCep(cep);
            return endereco;
        }
    }
}
