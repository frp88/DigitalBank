using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DigitalBank.Domain.Entities
{
    public class Endereco
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "O campo {0} é obrigatório."),
        StringLength(8, MinimumLength = 8,
            ErrorMessage = "O CEP deve ter 8 dígitos.")]
        [Display(Name = "CEP")]
        public string cep { get; set; }
        
        [MaxLength(255)]
        public string logradouro { get; set; }
       
        [MaxLength(255)]
        public string complemento { get; set; }
        
        [MaxLength(255)]
        public string bairro { get; set; }
        
        [MaxLength(255)]
        public string localidade { get; set; }
        
        [MaxLength(2, ErrorMessage = "A {0} deve ter exatamente 2 caracteres."), Display(Name = "UF")]
        public string uf { get; set; }

        public Endereco() { }

        public Endereco(string cep)
        {
            this.cep = cep;
        }
    }
}
