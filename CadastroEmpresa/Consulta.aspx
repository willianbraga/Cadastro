<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consulta.aspx.cs" Inherits="CadastroEmpresa.Entrevista" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style type="text/css">
        .auto-style1 {
            width: 203px;
        }
        .auto-style2 {
            width: 232px;
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
                            <asp:SqlDataSource ID="SqlDataSource2" runat="server"
                                ConnectionString="<%$ ConnectionStrings:FinanceiroDBConnectionString %>"
                                SelectCommand="SELECT * FROM [Empresa]"></asp:SqlDataSource>

                            <asp:SqlDataSource ID="SqlDataSource3" runat="server" 
                                ConnectionString="Data Source=WILL-NOTE\SQLExpress;Initial Catalog=FinanceiroDB;Integrated Security=True" 
                                ProviderName="System.Data.SqlClient" 
                                SelectCommand="SELECT EmpresaPessoa.EmpresaPessoaID, Pessoa.PessoaNome, Empresa.EmpresaNome, 
                                Empresa.EmpresaFaturamento, EmpresaPessoa.EmpresaPessoaExpec FROM EmpresaPessoa 
                                INNER JOIN Empresa ON EmpresaPessoa.EmpresaID = Empresa.EmpresaID 
                                INNER JOIN Pessoa ON EmpresaPessoa.PessoaID = Pessoa.PessoaID"></asp:SqlDataSource>

                            PAGINA CONSULTA E CADASTRO EMPRESA / FUNCIONARIO </h3>
                    </td>

                </tr>
                <tr>
                    <td class="auto-style1"></td>
                    <td class="auto-style2"></td>
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
                        <asp:DropDownList ID="ddlEmpresa" runat="server" Width="300px" DataSourceID="SqlDataSource2" DataTextField="EmpresaNome" DataValueField="EmpresaID">
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:Button Text="Selecionar Empresa" ID="btnSelEmpresa" runat="server" Width="200px" OnClick="btnSelEmpresa_Click" /></td>
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
                    <td class="auto-style2"></td>
                    <td>
                        <h4>Empresa</h4>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label Text="Nome:" runat="server" />
                        <asp:Label Text="" ID="lblNomeFuncionario" runat="server" />
                    </td>
                    <td class="auto-style2"></td>
                    <td>
                        <asp:Label Text="Nome:" runat="server" />
                        <asp:Label Text="" ID="lblNomeEmpresa" runat="server" /></td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label Text="Telefone:" runat="server" />
                        <asp:Label Text="" ID="lblTelFuncionario" runat="server" />
                    </td>
                    <td class="auto-style2"></td>
                    <td>
                        <asp:Label Text="Faturamento:" runat="server" />
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
                    <td style="text-align:center">
                        <asp:Button Text="Salvar" ID="btnSalvar" runat="server" Height="30px" Width="100px" OnClick="btnSalvar_Click" /></td>
                    <td style="text-align:center" class="auto-style2">
                        <asp:Label Text="" ID="lblErro"  runat="server" ForeColor="Red" /></td>
                    <td style="text-align:center">
                        <asp:Button Text="Voltar" ID="btnVoltar" runat="server"  Height="30px" Width="100px" OnClick="btnVoltar_Click" /></td>
                </tr>
            </table>
        </div>
        <div>
            <table style="margin:auto">
                <tr>
                    <td colspan="5" style="width: 750px">
                        <hr />
                    </td>
                </tr>
                <td style="text-align: center">
                    <h2>Funcionarios / Empresa</h2>
                </td>
                <tr>
                    <td colspan="5" style="text-align: center">
                        
                        <%--<asp:GridView ID="GridView1" runat="server" DatakeyName="EmpresaPessoaID"
                            onrowcancelingedit="EmpresaGV_RowCancelingEdit"
                            onrowediting="EmpresaGV_RowEditing"
                            onrowdeleting="EmpresaGV_RowDeleting"
                            onrowupdating="EmpresaGV_RowUpdating">

                            <Columns>
                                <asp:TemplateField HeaderText="Codigo">
                                    <ItemTemplate>
                                        <%#Container.DataItemIndex+1 %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Funcionario">
                                    <ItemTemplate>
                                        <%#Eval("PessoaNome")%>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txtnomefuncionario" runat="server" Text='<%#Eval("PessoaNome") %>' />
                                    </EditItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Empresa">
                                    <ItemTemplate>
                                        <%#Eval("EmpresaNome")%>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txtnomefuncionario" runat="server" Text='<%#Eval("EmpresaNome") %>' />
                                    </EditItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>--%>
                        
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
