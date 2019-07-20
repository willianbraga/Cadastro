<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consulta.aspx.cs" Inherits="CadastroEmpresa.Entrevista" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style type="text/css">
        .auto-style1 {
            width: 203px;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="margin: auto;">
                <tr>
                    <td colspan="5" style="text-align: center;">
                        <h3>
                            <%--                            <asp:SqlDataSource ID="SqlDataSource1" runat="server"
                                ConnectionString="<%$ ConnectionStrings:FinanceiroDBConnectionString %>"
                                SelectCommand="SELECT PessoaID, PessoaNome, PessoaTel FROM Pessoa">
                            </asp:SqlDataSource>--%>

                            <asp:SqlDataSource ID="SqlDataSource2" runat="server"
                                ConnectionString="<%$ ConnectionStrings:FinanceiroDBConnectionString %>"
                                SelectCommand="SELECT [EmpresaNome] FROM [Empresa]"></asp:SqlDataSource>

                            PAGINA CONSULTA E CADASTRO EMPRESA / FUNCIONARIO </h3>
                    </td>

                </tr>
                <tr>
                    <td class="auto-style1"></td>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td class="auto-style1">Funcionario:</td>
                    <td colspan="3" style="text-align: center">
                        <asp:DropDownList ID="ddlFuncionario" runat="server" Width="300px">
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:Button Text="Selecionar Funcionario" ID="btnSelFuncionario" runat="server" Width="200px" OnClick="btnSelFuncionario_Click" /></td>
                </tr>
                <tr>
                    <td class="auto-style1">Empresa:</td>
                    <td colspan="3" style="text-align: center">
                        <asp:DropDownList ID="ddlEmpresa" runat="server" Width="300px" DataSourceID="SqlDataSource2" DataTextField="EmpresaNome" DataValueField="EmpresaNome">
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:Button Text="Selecionar Empresa" ID="btnSelEmpresa" runat="server" Width="200px" /></td>
                </tr>
                <tr>
                    <td colspan="3">
                        <hr />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <h4>Funcionario</h4>
                    </td>
                    <td style="width: 200px"></td>
                    <td>
                        <h4>Empresa</h4>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label Text="Nome:" runat="server" />
                        <asp:Label Text="" ID="lblNomeFuncionario" runat="server" />
                    </td>
                    <td></td>
                    <td>
                        <asp:Label Text="Nome:" runat="server" />
                        <asp:Label Text="" ID="lblNomeEmpresa" runat="server" /></td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label Text="Telefone:" runat="server" />
                        <asp:Label Text="" ID="lblTelFuncionario" runat="server" />
                    </td>
                    <td></td>
                    <td>
                        <asp:Label Text="Telefone:" runat="server" />
                        <asp:Label Text="" ID="lblFatEmpresa" runat="server" /></td>
                </tr>
                <tr>
                    <td colspan="3">
                        <hr />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label Text="Expectativa de faturamento:" runat="server" /></td>
                    <td colspan="2" style="text-align: center;">
                        <asp:TextBox ID="txtExpectativa" runat="server" Width="300px" /></td>
                </tr>
                <tr>
                    <td colspan="3">
                        <hr />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button Text="Salvar" ID="btnSalvar" runat="server" /></td>
                    <td></td>
                    <td>
                        <asp:Button Text="Voltar" ID="btnVoltar" runat="server" /></td>
                </tr>
            </table>
        </div>
        <div>
            <table>
                <tr>
                    <td colspan="5" style="width: 750px">
                        <hr />
                    </td>
                </tr>
                <td style="text-align: center">
                    <h2>Funcionarios / Empresa</h2>
                </td>
                <tr>
                    <td></td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
