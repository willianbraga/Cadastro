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
        EmpresaEntity empresa = new EmpresaEntity();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    con = new SqlConnection(ConnectionString);
                    SqlCommand cmdFunc = new SqlCommand("SELECT PessoaID, PessoaNome, PessoaTel as funcionario FROM Pessoa", con);
                    con.Open();
                    SqlDataReader rd;
                    rd = cmdFunc.ExecuteReader();
                    ddlFuncionario.DataSource = rd;
                    ddlFuncionario.DataMember = "PessoaID";
                    ddlFuncionario.DataValueField = "funcionario";
                    ddlFuncionario.DataTextField = "PessoaNome";
                    ddlFuncionario.DataBind();

                    SqlCommand cmdEmp = new SqlCommand("SELECT EmpresaID, EmpresaNome, EmpresaFat as empresa FROM Empresa", con);
                    SqlDataReader rd1;
                    rd1 = cmdEmp.ExecuteReader();
                    ddlEmpresa.DataSource = rd1;
                    ddlEmpresa.DataMember = "EmpresaID";
                    ddlEmpresa.DataValueField = "empresa";
                    ddlEmpresa.DataTextField = "EmpresaFat";
                    ddlEmpresa.DataBind();

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
            string tel = model.GetTelFuncionario(funcionario.nomPessoa);
            lblTelFuncionario.Text = tel;
        }

        protected void btnSelEmpresa_Click(object sender, EventArgs e)
        {
            EmpresaPessoaModel model = new EmpresaPessoaModel();
            empresa.nomEmpresa = ddlEmpresa.SelectedItem.Text;
            string fat = model.GetFatEmpresa(empresa.nomEmpresa);
            lblFatEmpresa.Text = fat;
        }
    }
}