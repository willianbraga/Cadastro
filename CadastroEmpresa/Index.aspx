<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="CadastroEmpresa.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="margin: auto">
                <tr>
                    <td colspan="6" style="text-align:center"><h3>MENU</h3></td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button Text="Incluir Funcionario" ID="btnIncluirFuncionario" runat="server" Width="160px" Height="50px" OnClick="btnIncluirFuncionario_Click" /></td>
                    <td></td>
                    <td>
                        <asp:Button Text="Incluir Empresa" runat="server" ID="btnIncluirEmpresa" Width="160px" Height="50px" OnClick="btnIncluirEmpresa_Click" /></td>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button Text="Logout" ID="btnLogout" runat="server" Width="160px" Height="50px" /></td>
                    </td>
                    <td></td>
                    <td>
                        <asp:Button Text="Consulta e Cadastro" ID="btnEntrevista" runat="server" Width="160px" Height="50px" OnClick="btnEntrevista_Click" /></td>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
