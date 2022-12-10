using System;

namespace Domain.Models.Servicos
{
    public class ItemOrdemServico
    {
        public Guid? ItemOrdemServicoID { get; private set; }
        public Guid? ServicoID { get; private set; }
        public Guid? OrdemServicoID { get; private set; }   
        public ItemOrdemServico(Guid? itemOrdemServicoID = null,
            Guid? servicoID = null, Guid? ordemServicoID = null)
        {
            ItemOrdemServicoID = itemOrdemServicoID;           
            ServicoID = servicoID;
            OrdemServicoID = ordemServicoID;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is ItemOrdemServico)) return false;

            if ((obj as ItemOrdemServico).ItemOrdemServicoID.Equals(ItemOrdemServicoID)) return true;

            return false;
        }

        public override int GetHashCode()
        {
            return 11 * (ItemOrdemServicoID == null ? 1 : ItemOrdemServicoID.GetHashCode());
        }
    }
}
