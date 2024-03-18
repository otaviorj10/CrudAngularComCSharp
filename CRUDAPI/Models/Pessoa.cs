using System.ComponentModel.DataAnnotations;

namespace CRUDAPI.Models
{
    public class Pessoa
    {
        [Key]
        public int PessoalId { get; set; }
        public string Nome { get; set; }

        public string Sobrenome {get;set;}
        public int Idade {get;set;}
        
        public string Profissao { get; set; }
    }
}