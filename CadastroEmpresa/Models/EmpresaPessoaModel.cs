using CadastroEmpresa.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CadastroEmpresa.Models
{
    public class EmpresaPessoaModel
    {
        SqlConnection con = null;
        string ConnectionString = @"Data Source=WILL-NOTE\SQLEXPRESS;Initial Catalog=FinanceiroDB;Integrated Security=True";

        public string GetTelFuncionario(string nome)
        {
            PessoaEntity funcionario = new PessoaEntity();
            try
            {
                string query = "SELECT PessoaTel FROM Pessoa WHERE PessoaNome = @PessoaNom";
                var dt = new DataTable();
                using (con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    using (var cmdTel = new SqlCommand(query, con))
                    {
                        cmdTel.Parameters.AddWithValue("@PessoaNom", nome);
                        SqlDataReader reader = cmdTel.ExecuteReader();
                        dt.Load(reader);
                        reader.Close();
                    }
                    con.Close();
                }
                string telefone = dt.Rows[0][0].ToString();
                return telefone;
            }
            catch (SqlException)
            {
                return null;
            }
        }
        public string GetFatEmpresa(string faturamento)
        {
            try
            {
                string query = "SELECT EmpresaFat FROM Empresa";
                var dt = new DataTable();
                using (con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    using (var cmdfat = new SqlCommand(query,con))
                    {
                        cmdfat.Parameters.AddWithValue("@EmpresaFat", faturamento);
                        SqlDataReader reader = cmdfat.ExecuteReader();
                        dt.Load(reader);
                    }
                    con.Close();
                }
                string fat = dt.Rows[0][0].ToString();
                return fat;

            }
            catch (SqlException)
            {
                return null;
            }
        }
    }
}