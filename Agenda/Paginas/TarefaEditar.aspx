<%@ Page Language="vb" MasterPageFile="~/Site.Master" AutoEventWireup="false" CodeBehind="TarefaEditar.aspx.vb" Inherits="Agenda.TarefaEditar" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid box">
        <div class="modal-dialog modal-lg" role="document">
            <div class="modal-header">
               <h2>
                  <label>Tarefa</label> 
               </h2>
            </div>
            <div class="modal-body">
                <div  class="form-group">
                    <h6>
                        <asp:Label id="txtMensagem" Text="" Visible="false" runat="server" class="alert alert-danger" />    
                    </h6>
                </div>
                <div class="row">                   
                    <div class="form-group col-md-6">
                        <label>Título:</label>
                        <asp:TextBox id="txtTitulo" runat="server" class="form-control" MaxLength="50"/>
                    </div>
                
                    <div class="form-group col-md-6">
                        <label>Tipo de Atividade:</label>
                        <asp:DropDownList ID="drpTipoTarefa" runat="server" DataTextField="nome" DataValueField="id" class="form-control"></asp:DropDownList>
                    </div>                   
                </div>
                <div class="row">
                    <div class="form-group col-md-6">
                        <label>Descrição:</label>
                        <textarea id="txtDescricao" runat="server" class="form-control" rows="4"> </textarea>
                    </div>                      
                </div>
                <div class="row">
                    <div class="form-group col-md-4">
                        <label>Prazo:</label>
                        <asp:TextBox id="txtPrazo" MaxLength="10" runat="server" placeholder="dd/mm/yyyy" class="form-control"/> 
                    </div> 
                    <div class="form-group col-md-4">
                        <label>Status:</label>
                        <asp:DropDownList ID="drpStatus" runat="server" DataTextField="Nome" DataValueField="Id" class="form-control"/>
                    </div>
                    <div class="form-group col-md-4">
                        <label>Prioridade:</label>
                        <asp:DropDownList ID="drpPrioridade" runat="server" DataTextField="Nome" DataValueField="id" class="form-control" />
                    </div>
                </div>
                <div class="row">
                    <div class="form-group col-md-6">
                        <asp:Button ID="btnIncluirTarefa" runat="server" text="Incluir" class="btn btn-success"/>
                        <asp:Button ID="btnSalvarTarefa" runat="server" Text="Salvar" class="btn btn-success"/>
                        <asp:Button ID="btnExcluirTarefa" runat="server" Text="Excluir" class="btn btn-danger"/>
                        <asp:Button ID="btnVoltar" runat="server" Text="Voltar" class="btn btn-secondary"/>
                    </div>
                </div>

            </div>
        </div>
     </div>
</asp:Content>
