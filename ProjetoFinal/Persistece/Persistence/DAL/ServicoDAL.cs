using Domain.Models.Servicos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ProjetoFinal.Persistence.DAL
{
    public class ServicoDAL
    {
        private SqlConnection _sqlConnection;
        public ServicoDAL(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }
        private void Adicionar(Servico servico)
        {
            _sqlConnection.Open();
            SqlCommand command = _sqlConnection.CreateCommand();
            command.CommandText =
                "insert into Tb_Servico(ServicoID, Descricao, Preco)" +
                "values(@servicoID, @descricao, @preco)";
            command.Parameters.AddWithValue("@servicoID", Guid.NewGuid());
            command.Parameters.AddWithValue("@descricao", servico.Descricao);
            command.Parameters.AddWithValue("@preco", servico.Preco);

            command.ExecuteNonQuery();

            _sqlConnection.Close();
        }

        public IReadOnlyCollection<Servico> ObterTodos()
        {
            List<Servico> servicos = new List<Servico>();
            var command = new SqlCommand(
                "select ServicoID, Descricao, Preco from Tb_Servico order by Descricao",
                _sqlConnection);

            _sqlConnection.Open();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var servico = new Servico(
                        reader.GetString(1), reader.GetDecimal(2),
                        servicoID: reader.GetGuid(0));

                    servicos.Add(servico);
                }
            }
            _sqlConnection.Close();
            return servicos.AsReadOnly();
        }

        public Servico ObterPorID(Guid? servicoID)
        {
            Servico servico = null;
            var command = new SqlCommand("select ServicoID, Descricao, preco" +
                " from Tb_Servico where ServicoID = @servicoID");
            command.Parameters.AddWithValue("@servicoID", servicoID);
            _sqlConnection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    servico = new Servico(reader.GetString(1), reader.GetDecimal(2),
                        servicoID: reader.GetGuid(0));
                }
            }
            _sqlConnection.Close();
            return servico;
        }

        public void Gravar(Servico servico)
        {
            if (string.IsNullOrWhiteSpace(servico.Descricao)) 
            {
                throw new Exception("Nome não pode ser em branco");
            }
            if(servico.ServicoID == null)
            {
                Adicionar(servico);
            }else
            {
                Atualizar(servico);
            }
        }

        public void Remover(Servico servico)
        {
            var command = new SqlCommand(
                "delete TB_Servico " + "where ServicoID = @servicoID ", 
                _sqlConnection);

            command.Parameters.AddWithValue("@ServicoID", servico.ServicoID);

            _sqlConnection.Open();
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }

        private void Atualizar(Servico servico)
        {
            var command = new SqlCommand(
                "update TB_Servico " + "set descricao = @descricao, Preco = @preco " +
                "where ServicoID = @servicoID ", _sqlConnection);

            command.Parameters.AddWithValue("@Descricao", servico.Descricao);
            command.Parameters.AddWithValue("@Preco", servico.Preco);
            command.Parameters.AddWithValue("@ServicoID", servico.ServicoID);

            _sqlConnection.Open();
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }
    }       
}
