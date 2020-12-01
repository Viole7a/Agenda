<%@ Page Language="vb" MasterPageFile="~/Site.Master" AutoEventWireup="false" CodeBehind="Principal.aspx.vb" Inherits="Agenda.WebForm3" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid box">
        <h2>
            <asp:label ID="txtTitulo" runat="server"/>
        </h2>
        <h3>
            <label>Tarefas a fazer</label>
        </h3>
        <asp:GridView runat="server" ID="listaTarefas" AutoGenerateColumns="false" CssClass="table table-responsive table-striped table-bordered table-hover table-padrao">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="#" visible="true"/>
                <asp:BoundField DataField="titulo" HeaderText="Titulo" />
                <asp:BoundField DataField="descricao" HeaderText="Descricao" />
                <asp:BoundField DataField="prazo" HeaderText="Prazo" DataFormatString="{0:dd/MM/yyyy}" />
                <asp:BoundField DataField="tipoTarefa1.nome" HeaderText="Tipo de Tarefa" />
                <asp:ButtonField Text="Vizualizar" />
			</Columns>
        </asp:GridView>
        <table>
            <tr>
                <td>
                    <asp:Button id="btnIncluirTarefa" Text="Incluir Tarefa" runat="server" CssClass="btn btn-primary" />
                </td>
                <td>
                    <asp:Button id="btnTipoTarefa" Text="Tipos de Tarefa" runat="server" CssClass="btn btn-primary"/>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
