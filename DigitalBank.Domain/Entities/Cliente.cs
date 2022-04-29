using DigitalBank.Domain.Enumerations;
using DigitalBank.Domain.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBank.Domain.Entities
{
    public class Cliente: ICliente
    {
        public long? id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string? email { get; set; }
        public DateTime? dataDeNascimento { get; set; }
        public DateTime dataDeCadastro { get; set; }
        public SituacaoCliente situacao { get; set; }

        public ICollection<Conta> contas { get; set; }

        public Cliente() 
        {
            contas = new List<Conta>();
            dataDeCadastro = DateTime.Now;
            situacao = SituacaoCliente.Liberado;
        }

        public Cliente(string nome, string cpf) : this()
        {
            this.nome = nome;
            this.cpf = cpf;
        }

        public Cliente(string nome, string cpf, string email, DateTime dataDeNascimento) : this(nome, cpf)
        {
            this.email = email;
            this.dataDeNascimento = dataDeNascimento;
        }

        public int RetornarQuantidadeContasAtivas() =>
            contas.Count(c => c.situacao.Equals(SituacaoConta.Ativa));

        public int RetornarQuantidadeContasFinalizadas() =>
            contas.Count(c => c.dataDeFinalizacao.HasValue);
    }
}
