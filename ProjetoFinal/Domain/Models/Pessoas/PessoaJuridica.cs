using Domain.Models.Pessoas.Endereco;
using System;

namespace Domain.Models
{
    public class PessoaJuridica : Pessoa
    {
        public PessoaJuridica(string nome, string senha, string email,
            string telefone, Endereco endereco,Guid? pessoaID = null)
        {
            PessoaID = pessoaID;
            Nome = nome;
            Senha = senha;
            Email = email;
            Telefone = telefone;
            Endereco = endereco;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is PessoaJuridica)) return false;

            if ((obj as PessoaJuridica).PessoaID.Equals(PessoaID)) return true;

            return false;
        }

        public override int GetHashCode()
        {
            return 11 * (PessoaID == null ? 1 : PessoaID.GetHashCode());
        }

        private void validacao()
        {
            if (Nome == null)
                throw new Exception("O nome não pode ser nulo ou vazio");

            if(Senha == null)
                throw new Exception("A senha não pode ser nula ou vazia");

            if (Email == null)
                throw new Exception("O e-mail não pode ser nulo ou vazio");
        }
    }
}
