using CadastroEmpresa.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CadastroEmpresa.Models
{
    public class EmpresaPessoaModel
    {
        SqlConnection con = null;
        string ConnectionString = @"Data Source=WILL-NOTE\SQLEXPRESS;Initial Catalog=FinanceiroDB;Integrated Security=True";
        PessoaEntity funcionario = new PessoaEntity();

        public string GetTelFuncionario()
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
            string query = "SELECT PessoaTel FROM Pessoa WHERE PessoaNom=@PessoaNom";
            SqlCommand cmdTel = new SqlCommand(query, con);
            cmdTel.Parameters.AddWithValue("PessoaNom", funcionario.nomPessoa);
            string telefone = Convert.ToString(cmdTel.ExecuteNonQuery());
            return telefone;
        }
    }
}