using CadastroEmpresa.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CadastroEmpresa.Models;

namespace CadastroEmpresa
{
    public partial class Entrevista : System.Web.UI.Page
    {
        SqlConnection con = null;
        string ConnectionString = @"Data Source=WILL-NOTE\SQLEXPRESS;Initial Catalog=FinanceiroDB;Integrated Security=True";
        PessoaEntity funcionario = new PessoaEntity();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    con = new SqlConnection(ConnectionString);
                    SqlCommand cmdNome = new SqlCommand("SELECT PessoaID, PessoaNome, PessoaTel as funcionario FROM Pessoa", con);
                    con.Open();
                    SqlDataReader rd;
                    rd = cmdNome.ExecuteReader();
                    ddlFuncionario.DataSource = rd;
                    ddlFuncionario.DataMember = "PessoaID";
                    ddlFuncionario.DataValueField = "funcionario";
                    ddlFuncionario.DataTextField = "PessoaNome";

                    ddlFuncionario.DataBind();

                }
                catch (Exception ex)
                {

                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }
        }

        protected void btnSelFuncionario_Click(object sender, EventArgs e)
        {
            EmpresaPessoaModel model = new EmpresaPessoaModel();
            funcionario.nomPessoa = ddlFuncionario.SelectedItem.Text;
            lblNomeFuncionario.Text = funcionario.nomPessoa;
            string telefone = model.GetTelFuncionario();
            lblTelFuncionario.Text = telefone;
        }
        
    }
}