using DigitalBank.Domain.Enumerations;
using DigitalBank.Domain.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
namespace DigitalBank.Domain.Entities
{
    public class Cliente : ICliente
    {
        [Key]
        public long? id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório."),
          MaxLength(255)]
        public string nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "A quantidade de dígitos para o campo {0} é inválida.")]
        [Display(Name = "CPF")]
        public string cpf { get; set; }

        [MaxLength(255)]
        [EmailAddress(ErrorMessage = "O campo {0} é inválido.")]
        [Display(Name = "e-mail")]
        public string? email { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "data de nascimento")]
        public DateTime? dataDeNascimento { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "data de cadastro")]
        public DateTime dataDeCadastro { get; set; }

        [Display(Name = "situação")]
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
        public bool addConta(Conta conta)
        {
            if (conta == null)
                return false;
            contas.Add(conta);
            return true;
        }

        public int RetornarQuantidadeContasAtivas() =>
            contas.Count(c => c.situacao.Equals(SituacaoConta.Ativa));

        public int RetornarQuantidadeContasFinalizadas() =>
            contas.Count(c => c.dataDeFinalizacao.HasValue);

    }
}
