using System;

namespace Domain.Models.Servicos
{
    public class Servico
    {
        public Guid? ServicoID { get; private set; }
        public string Descricao { get; private set; }
        public decimal Preco { get; private set; }
        public Servico(string descricao, Guid? servicoID = null)
        {
            ServicoID = servicoID;
            Descricao = descricao;
           
        }
        public Servico(string descricao, decimal preco, Guid? servicoID) : this(descricao, servicoID)
        {
            Preco = preco;
        }

        public void Atualizar(string descricao,decimal preco)
        {
            Descricao = descricao;
            Preco = preco;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Servico)) return false;

            if ((obj as Servico).ServicoID.Equals(ServicoID)) return true;

            return false;
        }

        public override int GetHashCode()
        {
            return 11 * (ServicoID == null ? 1 : ServicoID.GetHashCode());
        }

    }
}
