using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using CadastroEmpresa.Entities;
using System.Globalization;
using CadastroEmpresa.Models;

namespace CadastroEmpresa
{
    public partial class CadastroEmpresa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {

            if (txtNome.Text == "" || txtFaturamento.Text == string.Empty)
            {
                lblErro.Visible = true;
            }
            else
            {
                lblErro.Visible = false;
                var empresa = new EmpresaEntity();
                empresa.nomEmpresa = txtNome.Text;
                empresa.fatEmpresa = Convert.ToDouble(txtFaturamento.Text);

                var model = new EmpresaModel();
                model.AdicionarEmpresa(empresa);
                ZerarValores();
                Response.Redirect("Index.aspx");
            }
        }
        private void ZerarValores()
        {
            txtNome.Text = txtFaturamento.Text = string.Empty;
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        protected void btnSalvarContinuar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtFaturamento.Text == string.Empty)
            {
                lblErro.Visible = true;
            }
            else
            {
                lblErro.Visible = false;
                var empresa = new EmpresaEntity();
                empresa.nomEmpresa = txtNome.Text;
                empresa.fatEmpresa = Convert.ToDouble(txtFaturamento.Text);

                var model = new EmpresaModel();
                model.AdicionarEmpresa(empresa);
                ZerarValores();
            }
        }
    }
}