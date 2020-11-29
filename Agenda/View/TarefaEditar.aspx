<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="TarefaEditar.aspx.vb" Inherits="Agenda.TarefaEditar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label id="txtMensagem" Text="" Visible="false" runat="server"/>
            <table>
                <tr>
                    <td>
                        <label>Título:</label>
                    </td>
                    <td>
                        <asp:TextBox id="txtTitulo" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <label>Tipo de Atividade:</label>
                    </td>
                    <td>
                        <asp:DropDownList ID="drpTipoTarefa" runat="server" DataTextField="nome" DataValueField="id"></asp:DropDownList>
                    </td>                    
                </tr>
                <tr>
                    <td>
                        <label>Descrição:</label>
                    </td>
                    <td>
                        <textarea id="txtDescricao" runat="server"> </textarea>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label>Prazo:</label>
                    </td>
                    <td>
                        <asp:TextBox id="txtPrazo" mask="##/##/####" runat="server"/> 
                    </td>                    
                </tr>
                <tr>
                    <td>
                        <label>Status:</label>
                    </td>
                    <td>
                        <asp:DropDownList ID="drpStatus" runat="server" DataTextField="Nome" DataValueField="Id" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <label>Prioridade:</label>
                    </td>
                    <td>
                        <asp:DropDownList ID="drpPrioridade" runat="server" DataTextField="Nome" DataValueField="id" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnIncluirTarefa" runat="server" text="Incluir"/>
                    </td>
                    <td>
                        <asp:Button ID="btnVoltar" runat="server" Text="Voltar" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
