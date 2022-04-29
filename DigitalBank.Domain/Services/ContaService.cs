using DigitalBank.Domain.Entities;
using DigitalBank.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBank.Domain.Services
{
    public class ContaService : IContaService
    {
        public ContaService()
        {

        }

        public Conta AdicionarConta(Conta novaConta)
        {
            throw new NotImplementedException();
        }

        public Conta AtualizarConta(long id, Conta ContaAtualizada)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Conta> BuscarConta()
        {
            throw new NotImplementedException();
        }

        public Conta BuscarContaPorId(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Conta> BuscarContaPorNumero(long numero)
        {
            throw new NotImplementedException();
        }

        public bool RemoverConta(long id)
        {
            throw new NotImplementedException();
        }
    }
}
