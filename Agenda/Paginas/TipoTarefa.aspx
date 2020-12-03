<%@ Page Language="vb" MasterPageFile="~/Site.Master" AutoEventWireup="false" CodeBehind="TipoTarefa.aspx.vb" Inherits="Agenda.TipoTarefa1" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="grid" style="margin-top: 40px">
        <div class="centered grid__col--12">            
            <h2 class="headline-secondary--grouped">Tipo de Tarefa</h2>                         
            <div>  
                <div class="form-group">
                    <h6>
                        <asp:Label id="txtMensagem" Text="" Visible="false" runat="server" class="grid__col--12 msg-warming" autosize="true" />    
                    </h6>
                </div>
                <div class="row">
                    <div class="form-group col-md-6">
                        <label>Nome:</label>
                        <asp:TextBox ID="txtNome" class="form__input" runat="server" />
                    </div>
                    <div class="form-group col-md-2">
                        <label>Cor:</label>
                        <input type="color" class="input-color"  id="inputColor" value="#e66465" runat="server">
                    </div>
                </div> 
                <div class="row">
                    <div class="form-group col-md-2">
                        <asp:Button id="btnIncluir" Text="Incluir" runat="server" class="btn--success"/>                        
                    </div>
                    <div class="form-group col-md-2">
                        <asp:Button ID="btnVoltar" Text="Voltar" runat="server" class="btn--default"/>
                    </div>
                </div>
                <div class="scroll-gridview">
                    <asp:GridView runat="server" ID="gridTipoTarefa" AutoGenerateColumns="false" CssClass="table table-responsive table-striped table-bordered table-hover table-padrao">
                        <Columns>
                            <asp:BoundField DataField="id" HeaderText="#" visible="true"/>
                            <asp:BoundField DataField="cor" HeaderText="CorHex" />
                            <asp:BoundField DataField="nome" HeaderText="Nome" />
                            <asp:BoundField DataField="" HeaderText="Cor" />
                            <asp:TemplateField>
                                    <ItemTemplate>                
                                        <asp:LinkButton runat="server" CommandArgument="<%# Container.DataItemIndex %>">
                                            <span class="glyphicon glyphicon-trash"/>
                                        </asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
			            </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
     </div>
</asp:Content>