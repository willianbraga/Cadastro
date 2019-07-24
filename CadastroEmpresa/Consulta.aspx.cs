using CadastroEmpresa.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CadastroEmpresa.Models;
using System.Globalization;

namespace CadastroEmpresa
{
    public partial class Entrevista : System.Web.UI.Page
    {
        SqlConnection con = null;
        EmpresaPessoaModel model = new EmpresaPessoaModel();


        string ConnectionString = @"Data Source=WILL-NOTE\SQLEXPRESS;Initial Catalog=FinanceiroDB;Integrated Security=True";
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
                    ddlFuncionario.DataMember = "funcionario";
                    ddlFuncionario.DataTextField = "PessoaNome";
                    ddlFuncionario.DataValueField = "PessoaID";
                    ddlFuncionario.DataBind();


                    //Instrução feita via SQLDataSource para fins didaticos.
                    //SqlCommand cmdEmp = new SqlCommand("SELECT EmpresaID, EmpresaNome, EmpresaFat as empresa FROM Empresa", con);
                    //SqlDataReader rd1;
                    //rd1 = cmdEmp.ExecuteReader();
                    //ddlEmpresa.DataSource = rd1;
                    //ddlEmpresa.DataMember = "EmpresaID";
                    //ddlEmpresa.DataValueField = "empresa";
                    //ddlEmpresa.DataTextField = "EmpresaFat";
                    //ddlEmpresa.DataBind();

                //    SqlCommand grid1 = new SqlCommand("SELECT EmpresaPessoa.EmpresaPessoaID, Pessoa.PessoaNome, " +
                //        "Empresa.EmpresaNome, Empresa.EmpresaFaturamento, " +
                //        "EmpresaPessoa.EmpresaPessoaExpec FROM EmpresaPessoa " +
                //        "INNER JOIN Empresa ON EmpresaPessoa.EmpresaID = Empresa.EmpresaID " +
                //        "INNER JOIN Pessoa ON EmpresaPessoa.PessoaID = Pessoa.PessoaID", con);
                //    SqlDataReader rd1 = grid1.ExecuteReader();
                //    gv1.DataSource = grid1;
                //    gv1.DataBind();
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
            PessoaEntity funcionario = new PessoaEntity();
            funcionario.codPessoa = Convert.ToInt32(ddlFuncionario.SelectedValue);

            funcionario = model.GetFuncionario(funcionario);
            lblNomeFuncionario.Text = funcionario.nomPessoa.ToString();
            lblTelFuncionario.Text = funcionario.telPessoa.ToString();
        }

        protected void btnSelEmpresa_Click(object sender, EventArgs e)
        {
            EmpresaEntity empresa = new EmpresaEntity();
            empresa.codEmpresa = Convert.ToInt32(ddlEmpresa.SelectedValue);

            empresa = model.GetEmpresa(empresa);
            lblNomeEmpresa.Text = empresa.nomEmpresa.ToString();
            lblFatEmpresa.Text = empresa.fatEmpresa.ToString("F2", CultureInfo.InvariantCulture);
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            EmpresaPessoaEntity cadastro = new EmpresaPessoaEntity();
            EmpresaPessoaModel contrato = new EmpresaPessoaModel();

            PessoaEntity funcionario = new PessoaEntity();
            funcionario.codPessoa = Convert.ToInt32(ddlFuncionario.SelectedValue);
            funcionario = contrato.GetFuncionario(funcionario);

            EmpresaEntity empresa = new EmpresaEntity();
            empresa.codEmpresa = Convert.ToInt32(ddlEmpresa.SelectedValue);
            empresa = contrato.GetEmpresa(empresa);

            if (lblNomeEmpresa.Text == "" || lblNomeFuncionario.Text == "")
            {   
                lblErro.Text = "Por favor selecione os valores acima.";
                return;
            }
            else if (txtExpectativa.Text == string.Empty)
            {
                lblErro.Text = "Por favor digite o valor de expectativa de faturamento.";
                return;
            }
            else
            {
                cadastro.Expectativa = Convert.ToDouble(txtExpectativa.Text);
                if (cadastro.Expectativa > empresa.fatEmpresa)
                {
                    lblErro.Text = "Valor de expectativa maior que faturamento.";
                }
                else
                {
                    cadastro.codEmpresa = empresa;
                    cadastro.codPessoa = funcionario;
                    contrato.AdicionarContrato(cadastro);
                }
            }
//            select fun.PessoaNome, em.EmpresaNome, em.EmpresaFaturamento, emp.EmpresaPessoaExpec
//from

//    EmpresaPessoa emp

//    inner join Empresa em on emp.EmpresaID = em.EmpresaID

//    inner join Pessoa fun on emp.PessoaID = fun.PessoaID

//    where emp.EmpresaPessoaID = (1)


        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}