using DigitalBank.Domain.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBank.Domain.Entities
{
    public class Cliente
    {
        public long? id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string? email { get; set; }
        public DateTime? dataDeNascimento { get; set; }
        public DateTime dataDeCadastro { get; set; }
        public SituacaoCliente situacao { get; set; }

        public Cliente()
        {
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
    }
}
