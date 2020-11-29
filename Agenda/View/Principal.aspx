<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Principal.aspx.vb" Inherits="Agenda.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>
                <asp:label ID="txtTitulo" runat="server"/>
            </h2>
            <h3>
                <label>Tarefas a fazer</label>
            </h3>
            <asp:GridView runat="server" ID="listaTarefas" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="#" visible="false"/>
                    <asp:BoundField DataField="titulo" HeaderText="Titulo" />
                    <asp:BoundField DataField="descricao" HeaderText="Descricao" />
                    <asp:BoundField DataField="prazo" HeaderText="Prazo" />
                    <asp:BoundField DataField="tipoTarefa1.nome" HeaderText="Tipo de Tarefa" />
                    <asp:ButtonField Text="Vizualizar" />
				</Columns>
            </asp:GridView>
            <table>
                <tr>
                    <td>
                        <asp:Button id="btnIncluirTarefa" Text="Incluir Tarefa" runat="server" />
                    </td>
                    <td>
                        <asp:Button id="btnTipoTarefa" Text="Tipos de Tarefa" runat="server" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
