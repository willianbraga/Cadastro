using CadastroEmpresa.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CadastroEmpresa.Models
{
    public class EmpresaModel
    {
        string connectionString = @"Data Source=WILL-NOTE\SQLEXPRESS;Initial Catalog=FinanceiroDB;Integrated Security=True";

        public void AdicionarEmpresa(EmpresaEntity empresa)
        {
            string sqlCmd = "insert into Empresa (EmpresaNome , EmpresaFaturamento ) values (@EmpresaNome , @EmpresaFaturamento)";

            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(sqlCmd, sqlConnection);
            cmd.Parameters.AddWithValue("@EmpresaNome", empresa.nomEmpresa);
            cmd.Parameters.AddWithValue("@EmpresaFaturamento", empresa.fatEmpresa);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}