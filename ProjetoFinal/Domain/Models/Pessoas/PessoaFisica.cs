using Domain.Models.Pessoas.Endereco;
using System;

namespace Domain.Models
{
    public class PessoaFisica : Pessoa
    {
        public string Sobrenome { get; private set; }
        public PessoaFisica(string nome, string sobrenome, string senha,
            string email, string telefone, Endereco endereco, Guid? pessoaID = null)
        {
            PessoaID = pessoaID;
            Nome = nome;
            Sobrenome = sobrenome;
            Senha = senha;
            Email = email;
            Telefone = telefone;
            Endereco = endereco;
        }
        public override bool Equals(object obj)
        {
            if (!(obj is PessoaFisica)) return false;

            if ((obj as PessoaFisica).PessoaID.Equals(PessoaID)) return true;

            return false;
        }

        public override int GetHashCode()
        {
            return 11 * (PessoaID == null ? 1 : PessoaID.GetHashCode());
        }
    }
}
