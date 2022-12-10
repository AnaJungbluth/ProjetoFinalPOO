using Domain.Models.Pessoas.Endereco;
using System;

namespace Domain.Models
{
    public abstract class Pessoa
    {
        public Guid? PessoaID { get; set; }
        public string Nome { get;  set; }   
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Senha { get; set; }

        public Endereco Endereco { get; set; }
    }
}
