<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Tarefas.aspx.vb" Inherits="Agenda.Tarefas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView runat="server" ID="listAtividades">
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="#" visible="false"/>
                    <asp:BoundField DataField="titulo" HeaderText="nome" />
                    <asp:BoundField DataField="descricao" HeaderText="descricao" />
				</Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
