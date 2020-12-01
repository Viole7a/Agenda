<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Cadastrar.aspx.vb" Inherits="Agenda.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="txtMensagem" runat="server" Visible="false" Text="" />
            <table>
                <tr>
                    <td>
                        <label>Nome: </label>
                    </td>
                    <td>
                        <asp:TextBox id="txtNome" runat="server"/>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label>Login: </label>
                    </td>
                    <td>
                        <asp:TextBox id="txtLogin" runat="server"/>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label>Senha: </label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtSenha" TextMode="Password" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnCadastrar" Text="Cadastrar" runat="server" />
                    </td>
                    <td>
                        <asp:Button ID="btnVoltar" Text="Voltar" runat="server" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
