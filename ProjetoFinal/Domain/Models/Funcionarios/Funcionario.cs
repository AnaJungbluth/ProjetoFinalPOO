using Domain.Models.Servicos;
using System;


namespace Domain.Models.Funcionarios
{
    public class Funcionario
    {
        public Guid? FuncionarioID { get; private set; }
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public string Email { get; private set; }
        public string Turno { get; private set; }
        public string Historico { get; private set; }
        public Guid? ServicoID { get; private set; }
        public Servico Servico { get; private set; }
        public Funcionario(string nome, string sobrenome, string email, string turno,
            string historico,  Guid? funcionarioID = null,  Guid? servicoID = null)
        {
            FuncionarioID = funcionarioID;
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
            Historico = historico;
            Turno = turno;
            ServicoID = servicoID;
            
        }
        public Funcionario(string nome, string sobrenome, string email, string turno,
            string historico, Guid? funcionarioID, Servico servico) :
            this(nome, sobrenome, email, turno, historico, funcionarioID, servico.ServicoID)
        {
            Servico = servico;
        }


        public void Atualizar(string email, string turno)
        {
            Email = email;
            Turno = turno;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Funcionario)) return false;

            if ((obj as Funcionario).FuncionarioID.Equals(FuncionarioID)) return true;

            return false;
        }

        public override int GetHashCode()
        {
            return 11 * (FuncionarioID == null ? 1 : FuncionarioID.GetHashCode());
        }

       

    }
}
