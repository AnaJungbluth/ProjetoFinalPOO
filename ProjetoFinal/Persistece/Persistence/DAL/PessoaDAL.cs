using Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Persistece.Persistence.DAL
{
    public class PessoaDAL
    {
        private SqlConnection _sqlConnection;
        public PessoaDAL(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }
        private void Adicionar(Pessoa pessoa)
        {
            _sqlConnection.Open();
            SqlCommand command = _sqlConnection.CreateCommand();
            if (pessoa.GetType() == typeof(PessoaFisica))
            {
                var p = pessoa as PessoaFisica;
                
                command.CommandText =
                    "insert into Tb_PessoaFisica(FisicaID, Nome, Sobrenome, Email, Telefone, " +
                    "Rua, Numero, Bairro, Senha )" +
                    "values(@fisicaID, @nome, @sobrenome, @email, @telefone, @rua, @numero," +
                    "@bairro, @senha)";
                command.Parameters.AddWithValue("@fisicaID", Guid.NewGuid());
                command.Parameters.AddWithValue("@nome", p.Nome);
                command.Parameters.AddWithValue("@sobrenome", p.Sobrenome);
                command.Parameters.AddWithValue("@email", p.Email);
                command.Parameters.AddWithValue("@telefone", p.Telefone);
                command.Parameters.AddWithValue("@rua", p.Endereco.Rua);
                command.Parameters.AddWithValue("@numero", p.Endereco.Numero);
                command.Parameters.AddWithValue("@bairro", p.Endereco.Bairro);
                command.Parameters.AddWithValue("@senha", p.Senha);

                
            }else if (pessoa.GetType() == typeof(PessoaJuridica)) {

                var p = pessoa as PessoaJuridica;

                command.CommandText =
                    "insert into Tb_PessoaJuridica(JuridicaID, Nome, Email, Telefone, " +
                    "Rua, Numero, Bairro, Senha )" +
                    "values(@juridicaID, @nome, @email, @telefone, @rua, @numero," +
                    "@bairro, @senha)";
                command.Parameters.AddWithValue("@juridicaID", Guid.NewGuid());
                command.Parameters.AddWithValue("@nome", p.Nome);
                command.Parameters.AddWithValue("@email", p.Email);
                command.Parameters.AddWithValue("@telefone", p.Telefone);
                command.Parameters.AddWithValue("@rua", p.Endereco.Rua);
                command.Parameters.AddWithValue("@numero", p.Endereco.Numero);
                command.Parameters.AddWithValue("@bairro", p.Endereco.Bairro);
                command.Parameters.AddWithValue("@senha", p.Senha);
            }
            command.ExecuteNonQuery();

            _sqlConnection.Close();
        }

        public void Gravar(Pessoa pessoa)
        {
            validacao(pessoa);
            if (pessoa.PessoaID == null)
            {
                Adicionar(pessoa);
            }
        }

        //public List<Pessoa> ObterClienteFisicoPorID (Guid pessoaID)
        //{                   
        //     List<Pessoa> clientes = new List<Pessoa>();

        //    var command = new SqlCommand("select FisicaID, Nome, Sobrenome, Email, Historico," +
        //        " ServicoID from Tb_Funcionario where ServicoID = @servicoID", _sqlConnection);

        //    command.Parameters.AddWithValue("@servicoID", servicoID);

        //    _sqlConnection.Open();

        //    using (SqlDataReader reader = command.ExecuteReader())
        //    {
        //        while (reader.Read())
        //        {
        //            funcionarios.Add(new Funcionario(reader.GetString(1), reader.GetString(2),
        //                reader.GetString(3), reader.GetString(4), reader.GetString(5), funcionarioID: reader.GetGuid(0),
        //                servicoID: reader.GetGuid(6)));
        //        }
        //    }
        //    _sqlConnection.Close();

        //    return funcionarios;
        //}

        private void validacao(Pessoa pessoa)
        {          
            if (string.IsNullOrWhiteSpace(pessoa.Nome))
                throw new Exception("O nome não pode ser vazio");

            if (pessoa.GetType() == typeof(PessoaFisica))
            {
                var p = pessoa as PessoaFisica;
                if (string.IsNullOrWhiteSpace(p.Sobrenome))
                    throw new Exception("O sobrenome não pode ser vazio");
            }

            if (string.IsNullOrWhiteSpace(pessoa.Email))
                throw new Exception("O email não pode ser vazio");

            if (string.IsNullOrWhiteSpace(pessoa.Senha))
                throw new Exception("A senha não pode ser vazio");

            if (string.IsNullOrWhiteSpace(pessoa.Telefone))
                throw new Exception("O telefone não pode ser nulo ou vazio");

            if (string.IsNullOrWhiteSpace(pessoa.Endereco.Rua))
                throw new Exception("O nome da rua não pode ser vazio");            

            if (string.IsNullOrWhiteSpace(pessoa.Endereco.Bairro))
                throw new Exception("O nome do bairro não pode ser vazio");

            if (string.IsNullOrWhiteSpace(pessoa.Endereco.Numero))
                throw new Exception("O número não pode ser vazio");
        }
    }
}
