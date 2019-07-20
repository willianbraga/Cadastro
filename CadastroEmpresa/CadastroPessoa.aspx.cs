using CadastroEmpresa.Entities;
using CadastroEmpresa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CadastroEmpresa
{
    public partial class CadastroPessoa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtTelefone.Text == "")
            {
                lblErro.Visible = true;
            }
            else
            {
                lblErro.Visible = false;
                var pessoa = new PessoaEntity();
                pessoa.nomPessoa = txtNome.Text;
                pessoa.telPessoa = txtTelefone.Text;

                var model = new PessoaModel();
                model.AdicionarPessoa(pessoa);

                ZerarValores();
                Response.Redirect("Index.aspx");
            }
        }
        public void ZerarValores()
        {
            txtNome.Text = txtTelefone.Text = string.Empty;
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }

        protected void btnSalvarContinuar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtTelefone.Text == "")
            {
                lblErro.Visible = true;
            }
            else
            {
                lblErro.Visible = false;
                var pessoa = new PessoaEntity();
                pessoa.nomPessoa = txtNome.Text;
                pessoa.telPessoa = txtTelefone.Text;
                var model = new PessoaModel();
                model.AdicionarPessoa(pessoa);
                ZerarValores();
            }
        }
    }
}