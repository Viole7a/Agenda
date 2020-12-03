<%@ Page Language="vb" MasterPageFile="~/Site.Master" AutoEventWireup="false" CodeBehind="TarefaEditar.aspx.vb" Inherits="Agenda.TarefaEditar" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="grid" style="margin-top: 40px">
        <div class="modal-dialog modal-lg" role="document">
            <h2 class="headline-secondary--grouped">Tarefa</h2>   
            <div>
                <div class="form-group">
                    <h6>
                        <asp:Label id="txtMensagem" Text="" Visible="false" runat="server" class="grid__col--12 msg-warming" autosize="true" />    
                        <asp:Label id="txtMensagemSucesso" Text="" Visible="false" runat="server" class="grid__col--12 msg-sucess" autosize="true" />    
                    </h6>
                </div>
                <div class="row">                   
                    <div class="form-group col-md-6">
                        <label>Título:</label>
                        <asp:TextBox id="txtTitulo" runat="server" class="form__input" MaxLength="50"/>
                    </div>                
                    <div class="form-group col-md-6">
                        <label>Tipo de Atividade:</label>
                        <asp:DropDownList ID="drpTipoTarefa" runat="server" DataTextField="nome" DataValueField="id" class="form__input"></asp:DropDownList>
                    </div>                   
                </div>
                <div class="row">
                    <div class="form-group col-md-6">
                        <label>Descrição:</label>
                        <textarea id="txtDescricao" runat="server" class="form__input" rows="5"> </textarea>
                    </div>
                    <div class="form-group col-md-6">
                        <div class="row">
                            <div class="form-group col-md-6">
                                <label>Prazo:</label>
                                <asp:TextBox id="txtPrazo" MaxLength="10" runat="server" placeholder="dd/mm/yyyy" class="form__input"/> 
                            </div> 
                        <div class="form-group col-md-6">
                            <label>Status:</label>
                            <asp:DropDownList ID="drpStatus" runat="server" DataTextField="Nome" DataValueField="Id" class="form__input"/>
                        </div>
                    </div>
                    <div class="row">
                        <div class="form-group col-md-12">
                            <label>Prioridade:</label>
                            <asp:DropDownList ID="drpPrioridade" runat="server" DataTextField="Nome" DataValueField="id" class="form__input" />
                        </div>
                    </div>
                    </div>
                </div>                
                <div class="row">
                    <div class="form-group col-md-6">
                        <asp:Button ID="btnIncluirTarefa" runat="server" text="Incluir" class="btn--success"/>
                        <asp:Button ID="btnSalvarTarefa" runat="server" Text="Salvar" class="btn--success"/>
                        <asp:Button ID="btnExcluirTarefa" runat="server" Text="Excluir" class="btn--error" OnClick="btnExcluirTarefa_Click" OnClientClick="return confirm('Confirma a exclusão?')"/>
                        <asp:Button ID="btnVoltar" runat="server" Text="Voltar" class="btn--default"/>
                    </div>
                </div>

            </div>
        </div>
     </div>
</asp:Content>
