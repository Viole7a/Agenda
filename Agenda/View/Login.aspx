<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="Agenda.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
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
                        <asp:Button ID="btnEntrar" Text="Entrar" runat="server" />
                    </td>
                    <td>
                        <asp:Button ID="btnCadastrar" Text="Cadastrar" runat="server" />
                    </td>
                </tr>
            </table>            
        </div>
    </form>
</body>
</html>
