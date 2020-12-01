<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="TipoTarefa.aspx.vb" Inherits="Agenda.TipoTarefa1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DataGrid ID="dtgTipoTarefa" runat="server">

            </asp:DataGrid>
            <table>               
                <tr>
                    <td>
                        <label>Nome:</label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtNome" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <label>Cor:</label>
                    </td>
                    <td>
                        <asp:DropDownList id="drpCor" runat="server"/>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button id="btnIncluir" Text="Incluir" runat="server"/>
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
