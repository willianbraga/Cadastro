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

        public void AdicionarContrato(EmpresaPessoaEntity contrato)
        {
            string sqlCmd = "insert into EmpresaPessoa (EmpresaID , PessoaID, EmpresaPessoaExpec ) values (@EmpresaID , @PessoaID, @Expectativa)";

            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(sqlCmd, sqlConnection);
            cmd.Parameters.AddWithValue("@EmpresaID", contrato.codEmpresa.codEmpresa);
            cmd.Parameters.AddWithValue("@PessoaID", contrato.codPessoa.codPessoa);
            cmd.Parameters.AddWithValue("@Expectativa", contrato.Expectativa);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public PessoaEntity GetFuncionario(PessoaEntity funcionario)
        {
            string query = "SELECT * FROM Pessoa WHERE PessoaID=@funcionarioID";

            using (con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (var cmdFun = new SqlCommand(query, con))
                {
                    cmdFun.Parameters.AddWithValue("@funcionarioID", funcionario.codPessoa);
                    using (SqlDataReader reader = cmdFun.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            funcionario.nomPessoa = reader["PessoaNome"].ToString();
                            funcionario.telPessoa = reader["PessoaTel"].ToString();

                        }
                        return funcionario;
                    }
                }
            }
        }

        public EmpresaEntity GetEmpresa(EmpresaEntity empresa)
        {
            string query = "SELECT * FROM Empresa WHERE EmpresaID=@EmpresaID";

            using (con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (var cmdFun = new SqlCommand(query, con))
                {
                    cmdFun.Parameters.AddWithValue("@EmpresaID", empresa.codEmpresa);
                    using (SqlDataReader reader = cmdFun.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            empresa.nomEmpresa = reader["EmpresaNome"].ToString();
                            empresa.fatEmpresa = Convert.ToDouble(reader["EmpresaFaturamento"]);

                        }
                        return empresa;
                    }
                }
            }

        }
    }
}