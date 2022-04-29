using DigitalBank.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBank.Domain.Interfaces.Services
{
    public interface IPessoaService
    {     
        IEnumerable<Pessoa> BuscarPessoa();

        Pessoa BuscarPessoaPorId(long id);

        IEnumerable<Pessoa> BuscarPessoaPorNome(string nome);

        Pessoa AdicionarPessoa(Pessoa novaPessoa);


        Pessoa AtualizarPessoa(long id, Pessoa PessoaAtualizada);

        bool RemoverPessoa(long id);

        // bool temPessoasNoDB();

        // void SalvaCincoPessoasNoDB();

    }
}
