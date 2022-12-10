using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Domain.Models.Funcionarios;
using Domain.Models.Servicos;

namespace Persistece.Persistence.DAL
{
    public class FuncionarioDAL
    {
        private SqlConnection _sqlConnection;
        public FuncionarioDAL(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }
        private void Adicionar(Funcionario funcionario)
        {
            _sqlConnection.Open();

            SqlCommand command = _sqlConnection.CreateCommand();

            command.CommandText =
                "insert into Tb_Funcionario(FuncionarioID, Nome, Sobrenome, Email," +
                "Turno, Historico, ServicoID) " +
                "values(@funcionarioID, @nome, @sobrenome, @email, @turno, @historico," +
                "@servicoID)";
            command.Parameters.AddWithValue("@funcionarioID", Guid.NewGuid());
            command.Parameters.AddWithValue("@nome", funcionario.Nome);
            command.Parameters.AddWithValue("@sobrenome", funcionario.Sobrenome);
            command.Parameters.AddWithValue("@email", funcionario.Email);
            command.Parameters.AddWithValue("@turno", funcionario.Turno);
            command.Parameters.AddWithValue("@historico", funcionario.Historico);
            command.Parameters.AddWithValue("@servicoID", funcionario.ServicoID);


            command.ExecuteNonQuery();

            _sqlConnection.Close();
        }

        public IReadOnlyCollection<Funcionario> ObterTodos()
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            var command = new SqlCommand(
                "select FuncionarioID, Nome, Sobrenome, Email, Turno, Historico, ServicoID " +
                "from Tb_Funcionario order by Nome", _sqlConnection);

                _sqlConnection.Open();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var funcionario = new Funcionario(
                        reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), 
                        reader.GetString(5), servicoID: reader.GetGuid(6), funcionarioID: reader.GetGuid(0)                        
                        );
                    
                    funcionarios.Add(funcionario);
                }
            }

            _sqlConnection.Close();

            return funcionarios.AsReadOnly();
        }

        //public Funcionario ObterPorID(Guid? funcionarioID)
        //{
        //    Funcionario funcionario = null;
        //    var command = new SqlCommand("select FuncionarioID, Nome, Sobrenome, " +
        //        " Email, Turno, Historico from Tb_Funcionario" +
        //        " where FuncionarioID = @funcionarioID");

        //    command.Parameters.AddWithValue("@funcionarioID", funcionarioID);

        //    _sqlConnection.Open();

        //    using (SqlDataReader reader = command.ExecuteReader())
        //    {
        //        while (reader.Read())
        //        {
        //            funcionario = new Funcionario(reader.GetString(1), reader.GetString(2),
        //                reader.GetString(3), reader.GetString(4), reader.GetString(5),
        //                funcionarioID: reader.GetGuid(0));
        //        }
        //    }
        //}

        public List<Funcionario> ObterFuncionariosPorServico(Guid servicoID)
        {

            List<Funcionario> funcionarios = new List<Funcionario>();

            var command = new SqlCommand("select FuncionarioID, Nome, Sobrenome, Email, Turno, Historico," +
                " ServicoID from Tb_Funcionario where ServicoID = @servicoID", _sqlConnection);

            command.Parameters.AddWithValue("@servicoID", servicoID);

            _sqlConnection.Open();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    funcionarios.Add(new Funcionario(reader.GetString(1), reader.GetString(2),
                        reader.GetString(3), reader.GetString(4), reader.GetString(5), funcionarioID: reader.GetGuid(0),
                        servicoID: reader.GetGuid(6)));
                }
            }
            _sqlConnection.Close();

            return funcionarios;
        }

        public void Gravar(Funcionario funcionario)
        {

            validacao(funcionario);
            if (funcionario.FuncionarioID == null)
            {
                Adicionar(funcionario);
            }
            else
            {
                Atualizar(funcionario);
            }
        }

        public void Remover(Funcionario funcionario)
        {
            var command = new SqlCommand(
                "delete Tb_Funcionario where FuncionarioID = @funcionarioID ",
                _sqlConnection);

            command.Parameters.AddWithValue("@FuncionarioID", funcionario.FuncionarioID);

            _sqlConnection.Open();
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }

        private void Atualizar(Funcionario funcionario)
        {
            var command = new SqlCommand(
                "update Tb_Funcionario set Nome = @Nome, Sobrenome = @sobrenome, " +
                "Email = @email, Turno = @turno, Historico = @Historico, ServicoID = @servicoID " +
                "where FuncionarioID = @funcionarioID ", _sqlConnection);

            command.Parameters.AddWithValue("@nome", funcionario.Nome);
            command.Parameters.AddWithValue("@sobrenome", funcionario.Sobrenome);
            command.Parameters.AddWithValue("@email", funcionario.Email);
            command.Parameters.AddWithValue("@turno", funcionario.Turno);
            command.Parameters.AddWithValue("@historico", funcionario.Historico);
            command.Parameters.AddWithValue("@servicoID", funcionario.ServicoID);
            command.Parameters.AddWithValue("@funcionarioID", funcionario.FuncionarioID);


            _sqlConnection.Open();
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }

        private void validacao(Funcionario funcionario)
        {
            if (string.IsNullOrWhiteSpace(funcionario.Nome))
                throw new Exception("O nome não pode ser nulo ou vazio");

            if (string.IsNullOrWhiteSpace(funcionario.Sobrenome))
                throw new Exception("O sobrenome não pode ser nulo ou vazio");

            if (string.IsNullOrWhiteSpace(funcionario.Email))
                throw new Exception("O email não pode ser nulo ou vazio");

            if (string.IsNullOrWhiteSpace(funcionario.Turno))
                throw new Exception("O historico não pode ser nulo ou vazio");

            if (string.IsNullOrWhiteSpace(funcionario.Historico))
                throw new Exception("O turno não pode ser nulo ou vazio");

            if (funcionario.ServicoID == null)
                throw new Exception("É preciso selecionar um servico");
        }
    }

}

