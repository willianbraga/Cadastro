using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CadastroEmpresa
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIncluirFuncionario_Click(object sender, EventArgs e)
        {
            Response.Redirect("CadastroPessoa.aspx");
        }

        protected void btnIncluirEmpresa_Click(object sender, EventArgs e)
        {
            Response.Redirect("CadastroEmpresa.aspx");
        }

        protected void btnEntrevista_Click(object sender, EventArgs e)
        {
            Response.Redirect("Consulta.aspx");
        }
    }
}