using DigitalBank.Domain.Entities;
using DigitalBank.Infrastructure.Data.Repositories;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace DigitalBank.Infrastructure.Test.Data.Repositories
{
    public class ClienteRepositoryTests
    {
        private readonly ClienteRepository _clienteRepository;

        public ClienteRepositoryTests()
        {
            var dbInMemory = new DBInMemory();
            var context = dbInMemory.GetContext();
            _clienteRepository = new ClienteRepository(context);
        }

        [Fact]
        public async Task Buscar()
        {
            var clientes = await _clienteRepository.Buscar();
            Assert.Equal(3, clientes.Count());
        }

        [Fact]
        public async Task BuscarPorId()
        {
            var cliente = await _clienteRepository.BuscarPorId(1);
            Assert.NotNull(cliente);
        }

        [Fact]
        public async Task BuscarPorNome()
        {
            var clientes = await _clienteRepository.BuscarPorNome("Maria");
            Assert.NotNull(clientes);
        }

        [Fact]
        public async Task Adicionar()
        {
            var cliente = new Cliente("João", "22244466688");
            var sucesso = await _clienteRepository.Adicionar(cliente);
            Assert.True(sucesso);
        }

    }
}