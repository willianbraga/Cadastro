<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroPessoa.aspx.cs" Inherits="CadastroEmpresa.CadastroPessoa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <table style="margin:auto;">
                <tr><td colspan="3" style="text-align:center;" ><h3>CADASTRAR FUNCIONARIO</h3></td></tr>
                <tr>
                    <td style="width:150px;text-align:center;">
                        <asp:Label Text="Nome:"  runat="server" />
                    </td>
                    <td colspan="2" style="width:150px;">
                        <asp:TextBox ID="txtNome" runat="server" Width="300px" />
                    </td>
                </tr>
                <tr>
                    <td style="width:150px;text-align:center;">
                        <asp:Label Text="Telefone:"  runat="server" />
                    </td>
                    <td colspan="2" style="width:150px;">
                        <asp:TextBox ID="txtTelefone" runat="server" Width="300px" />
                    </td>
                </tr>
                <tr>
                    <td style="width:150px; text-align:center;">
                        <asp:Button Text="Salvar e Voltar" ID="btnSalvar" runat="server" Height="30px" Width="120px" OnClick="btnSalvar_Click"  />
                        </td>
                    <td style="width:150px;text-align:center">
                        <asp:Button Text="Cancelar" ID="btnCancelar" runat="server" Height="30px" Width="120px" OnClick="btnCancelar_Click" />

                    </td>
                    <td style="width:150px;text-align:center;">
                        <asp:Button Text="Salvar e Continuar" ID="btnSalvarContinuar" runat="server" Height="30px" Width="120px" OnClick="btnSalvarContinuar_Click"  />
                        </td>
                </tr>
                <tr>
                    <td colspan="3" style="text-align:center;">
                        <asp:Label Text="Favor incluir os dados acima." ID="lblErro" runat="server" ForeColor="Red" Visible="false" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>

