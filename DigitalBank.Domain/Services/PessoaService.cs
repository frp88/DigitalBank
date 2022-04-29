using DigitalBank.Domain.Entities;
using DigitalBank.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBank.Domain.Services
{
    public class PessoaService : IPessoaService
    {
        public PessoaService()
        {

        }

        public Pessoa AdicionarPessoa(Pessoa novaPessoa)
        {
            throw new NotImplementedException();
        }

        public bool AdicionarContaParaPessoa(Conta conta)
        {
            throw new NotImplementedException();
        }

        public Pessoa AtualizarPessoa(long id, Pessoa PessoaAtualizada)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pessoa> BuscarPessoa()
        {
            List<Pessoa> Pessoas = new List<Pessoa>();
            for (int i = 1; i < 6; i++)
            {
                var c = new Pessoa();
                Pessoas.Add(c);
            }
            return Pessoas;
        }

        public Pessoa BuscarPessoaPorId(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pessoa> BuscarPessoaPorNome(string nome)
        {
            throw new NotImplementedException();
        }

        public bool RemoverPessoa(long id)
        {
            throw new NotImplementedException();
        }
    }
}
