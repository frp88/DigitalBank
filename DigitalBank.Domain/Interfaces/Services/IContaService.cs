using DigitalBank.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBank.Domain.Interfaces.Services
{
    internal interface IContaService
    {     

        IEnumerable<Conta> BuscarConta();

        Conta BuscarContaPorId(long id);

        IEnumerable<Conta> BuscarContaPorNumero(long numero);

        Conta AdicionarConta(Conta novaConta);

        Conta AtualizarConta(long id, Conta ContaAtualizada);

        bool RemoverConta(long id);

        // bool temContasNoDB();

        // void SalvaCincoContasNoDB();

    }
}
