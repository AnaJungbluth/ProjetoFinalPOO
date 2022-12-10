using System;

namespace Domain.Models.Servicos
{
    public class OrdemServico
    {
        public Guid? OrdemServicoID { get; private set; }
        public decimal Valor { get; private set; }
        public Guid? FuncionarioID { get; private set; }
        public Guid? ClienteID { get; private set; }
        public OrdemServico(decimal valor, Guid? ordemServicoID = null,
            Guid? funcionarioID = null, Guid? clienteID = null)
        {
            OrdemServicoID = ordemServicoID;
            Valor = valor;
            FuncionarioID = funcionarioID;
            ClienteID = clienteID;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is OrdemServico)) return false;

            if ((obj as OrdemServico).OrdemServicoID.Equals(OrdemServicoID)) return true;

            return false;
        }

        public override int GetHashCode()
        {
            return 11 * (OrdemServicoID == null ? 1 : OrdemServicoID.GetHashCode());
        }
    }
}
