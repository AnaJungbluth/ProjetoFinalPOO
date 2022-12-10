using Domain.Models.Servicos;
using System;
using System.Data.SqlClient;

namespace Persistece.Persistence.DAL
{
    public class OrdemServicoDAL
    {
        private SqlConnection _sqlConnection;
        public OrdemServicoDAL(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }
        private Guid Adicionar(OrdemServico servico)
        {
            Guid ordemServicoID = Guid.NewGuid();
            _sqlConnection.Open();
            SqlCommand command = _sqlConnection.CreateCommand();
            command.CommandText =
                "insert into Tb_OrdemServico(OrdemServicoID, Valor, FuncionarioID," +
                "ClienteID) values(@ordemServicoID, @valor, @funcionarioID, @clienteID)";

            command.Parameters.AddWithValue("@ordemServicoID", ordemServicoID);
            command.Parameters.AddWithValue("@valor", servico.Valor);
            command.Parameters.AddWithValue("@funcionarioID", servico.FuncionarioID);
            command.Parameters.AddWithValue("@clienteID", servico.ClienteID);


            command.ExecuteNonQuery();

            _sqlConnection.Close();

            return ordemServicoID;
        }

        public OrdemServico ObterFuncionarioPorServico(Guid funcionarioID)
        {
            OrdemServico funcionario = null;
            var command = new SqlCommand("select OrdemServicoID, Valor, FuncionarioID," +
                " ClienteID  from Tb_OrdemServico" +
                " where FuncionarioID = @funcionarioID", _sqlConnection);

            command.Parameters.AddWithValue("@funcionarioID", funcionarioID);

            _sqlConnection.Open();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    funcionario = new OrdemServico(reader.GetDecimal(1),
                        ordemServicoID: reader.GetGuid(0),
                        funcionarioID: reader.GetGuid(2),
                        clienteID: reader.GetGuid(3));
                }
            }
            _sqlConnection.Close();

            return funcionario;
        }

        public Guid Gravar(OrdemServico servico)
        {
            if (servico.OrdemServicoID == null)
            {
                return Adicionar(servico);
            }
            return (Guid)servico.OrdemServicoID;
        }

    }
}
