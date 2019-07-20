using CadastroEmpresa.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace CadastroEmpresa.Models
{
    public class PessoaModel
    {
        string connectionString = @"Data Source=WILL-NOTE\SQLEXPRESS;Initial Catalog=FinanceiroDB;Integrated Security=True";
        public void AdicionarPessoa(PessoaEntity pessoa)
        {
            string sqlCmd = "insert into Pessoa (PessoaNome,PessoaTel) Values (@PessoaNome, @PessoaTel)";

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand(sqlCmd, connection);
            cmd.Parameters.AddWithValue("@PessoaNome", pessoa.nomPessoa);
            cmd.Parameters.AddWithValue("@PessoaTel", pessoa.telPessoa);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}