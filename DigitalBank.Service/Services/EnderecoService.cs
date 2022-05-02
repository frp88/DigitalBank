using DigitalBank.Domain.Entities;
using DigitalBank.Domain.Interfaces.ExternalServices;
using DigitalBank.Domain.Interfaces.Services;
using DigitalBank.Domain.Interfaces.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBank.Service.Services
{

    public class EnderecoService : IEnderecoService
    {
        private readonly IEnderecoExternalService _enderecoExternalService;

        public EnderecoService(IEnderecoExternalService enderecoExternalService)
        {
            _enderecoExternalService = enderecoExternalService;
        }

        public async Task<Endereco> BuscarEnderecoPorCep(string cep)
        {
            return await _enderecoExternalService.BuscarPorCep(cep);
        }
    }
}
