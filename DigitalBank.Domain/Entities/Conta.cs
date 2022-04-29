using DigitalBank.Domain.Enumerations;
using DigitalBank.Domain.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBank.Domain.Entities
{
    public abstract class Conta : IConta
    {
        public long? id { get; set; }
        public Cliente cliente { get; set; }
        public long numero { get; set; }
        public decimal saldo { get; private set; }
        public SituacaoConta situacao { get; private set; }
        public DateTime dataDeCadastro { get; set; }

        public DateTime? dataDeFinalizacao { get; set; }

        public Conta()
        {
            saldo = 0;
            situacao = SituacaoConta.Ativa;
            dataDeCadastro = DateTime.Now;
        }

        public Conta(Cliente cliente) : this()
        {
            this.cliente = cliente;
            Random random = new Random();
            numero = random.Next();
        }

        public Conta(Cliente cliente, long numero) : this()
        {
            this.cliente = cliente;
            this.numero = numero;
        }
     
        public virtual decimal Sacar(decimal valor)
        {
            if (valor > saldo)
                return -1;
            saldo -= valor;
            return saldo;
        }

        public decimal Depositar(decimal valor)
        {
            saldo += valor;
            return saldo;
        }

        public string VerSaldo()
        {
            return saldo.ToString("C2");
        }
        public string Finalizar()
        {
            if (dataDeFinalizacao != null)
                return "Essa conta já está finalizada / fechada.";
            else if (saldo != 0)
                return "Para fechar a conta o saldo precisa ser igual a R$ 0,00.";
            else
            {
                situacao = SituacaoConta.Finalizada;
                dataDeFinalizacao = DateTime.Now;
                return "ok";
            }
        }
    }
}

