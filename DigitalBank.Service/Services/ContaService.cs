using DigitalBank.Domain.Entities;
using DigitalBank.Domain.Interfaces.Repositories;
using DigitalBank.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalBank.Service.Services
{
    public class ContaService : IContaService
    {
        private readonly IContaRepository _contaRepository;
        public ContaService(IContaRepository contaRepository)
        {
            _contaRepository = contaRepository;
        }

        public async Task<Conta> AdicionarConta(Conta conta)
        {
            var adicaoOk = await _contaRepository.Adicionar(conta);
            if (adicaoOk == false)
                throw new Exception("Falha ao cadastrar a conta.");
            return conta;
        }

        public async Task<Conta> AtualizarConta(long id, Conta conta)
        {
            if (await _contaRepository.BuscarPorId(id) == null)
                return null;

            var atualizacaoOk = await _contaRepository.Atualizar(conta);
            if (!atualizacaoOk)
                return null;

            return conta;
        }

        public async Task<Conta> BuscarContaPorId(long id)
        {
            var conta = await _contaRepository.BuscarPorId(id);
            return conta;
        }

        public async Task<Conta> BuscarContaPorNumero(long numero)
        {
            var conta = await _contaRepository.BuscarPorNumero(numero);
            return conta;
        }

        public async Task<IEnumerable<Conta>> BuscarContas()
        {
            var contas = await _contaRepository.Buscar();
            if (contas == null || contas.ToList().Count == 0)
                return null;
            return contas;
        }

        public async Task<bool> RemoverConta(long id)
        {
            var conta = await _contaRepository.BuscarPorId(id);
            if (conta == null)
                return false;

            return await _contaRepository.Remover(conta);
        }
    }
}
