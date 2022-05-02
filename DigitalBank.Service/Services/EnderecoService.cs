using DigitalBank.Domain.Entities;
using DigitalBank.Domain.Interfaces.Services;
using DigitalBank.Infrastructure.CrossCutting.ExternalServices;
using System.Threading.Tasks;

namespace DigitalBank.Service.Services
{

    public class EnderecoService : IEnderecoService
    {
              public EnderecoService( )
        {
          
        }

        public async Task<Endereco> BuscarEnderecoPorCep(string cep)
        {
            return await EnderecoExternalService.BuscarPorCep(cep);
        }
    }
}
