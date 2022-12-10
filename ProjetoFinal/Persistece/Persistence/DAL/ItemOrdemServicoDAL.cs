using Domain.Models.Servicos;
using System;
using System.Data.SqlClient;

namespace Persistece.Persistence.DAL
{
    public class ItemOrdemServicoDAL
    {
        private SqlConnection _sqlConnection;
        public ItemOrdemServicoDAL(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }
        private void Adicionar(ItemOrdemServico servico)
        {
            _sqlConnection.Open();
            SqlCommand command = _sqlConnection.CreateCommand();

            command.CommandText =
                "insert into Tb_ItemOrdemServico(ItemOrdemServicoID, ServicoID, OrdemServicoID) " +
                "values(@itemOrdemServicoID, @servicoID, @ordemServicoID)";

            command.Parameters.AddWithValue("@itemOrdemServicoID", Guid.NewGuid());
            command.Parameters.AddWithValue("@servicoID", servico.ServicoID);
            command.Parameters.AddWithValue("@ordemServicoID", servico.OrdemServicoID);
            
            command.ExecuteNonQuery();

            _sqlConnection.Close();
        }

        public void Gravar(ItemOrdemServico servico)
        {
            if (servico.ItemOrdemServicoID == null)
            {
                Adicionar(servico);
            }
        }
    }
}
