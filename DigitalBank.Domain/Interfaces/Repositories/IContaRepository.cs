using DigitalBank.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBank.Domain.Interfaces.Repositories
{
    public interface IContaRepository
    {     
        IEnumerable<Conta> Buscar();

        Conta BuscarPorId(long id);

        IEnumerable<Conta> BuscarPorNumero(long numero);

        Conta Adicionar(Conta novaConta);

        bool AdicionarConta(Conta conta);

        Conta Atualizar(long id, Conta ContaAtualizada);

        bool Remover(long id);

    }
}
