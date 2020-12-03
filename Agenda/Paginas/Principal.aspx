<%@ Page Language="vb" MasterPageFile="~/Site.Master" AutoEventWireup="false" CodeBehind="Principal.aspx.vb" Inherits="Agenda.WebForm3" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="grid" style="margin-top: 40px">
        <div class="centered grid__col--12"> 
            <h2 class="headline-primary--grouped">
                <asp:label ID="txtTitulo" runat="server"/>
            </h2>
            <div>
                <div class="row" style="margin-top: 20px;"> 
                    <div class="form-group col-md-2">
                        <asp:Button id="btnIncluirTarefa" Text="Incluir Tarefa" runat="server" CssClass="btn--default" />
                    </div>
                    <div class="form-group col-md-2">
                        <asp:Button id="btnTipoTarefa" Text="Tipos de Tarefa" runat="server" CssClass="btn--default"/>
                    </div>
                </div>
                <div id="divTarefasAFazer" runat="server">
                <h3 class="headline-secondary--grouped">Tarefas a fazer </h3>
                    <div class="scroll-gridview">
                        <asp:GridView runat="server" ID="gridTarefasAFazer" AutoGenerateColumns="false" CssClass="table table-responsive table-striped table-bordered table-hover table-padrao">
                            <Columns>
                                <asp:BoundField DataField="id" HeaderText="#" />
                                <asp:BoundField DataField="tipoTarefa1.cor" HeaderText="cor" />
                                <asp:BoundField DataField="titulo" HeaderText="Titulo" />
                                <asp:BoundField DataField="prioridade1.nome" HeaderText="Prioridade" />
                                <asp:BoundField DataField="prazo" HeaderText="Prazo" DataFormatString="{0:dd/MM/yyyy}" />
                                <asp:BoundField DataField="tipoTarefa1.nome" HeaderText="Tipo de Tarefa" />
                                <asp:TemplateField>
                                    <ItemTemplate>                
                                        <asp:LinkButton runat="server" CommandArgument="<%# Container.DataItemIndex %>">
                                            <span class="glyphicon glyphicon-search"/>
                                        </asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
			                </Columns>
                        </asp:GridView>
                    </div>
                </div>
                <div id="divTarefasFinalizadas" runat="server">
                    <h3 class="headline-secondary--grouped">Tarefas finalizadas </h3>
                    <div class="scroll-gridview">
                        <asp:GridView runat="server" ID="gridTarefasFinalizadas" AutoGenerateColumns="false" CssClass="table table-responsive table-striped table-bordered table-hover table-padrao">
                            <Columns>
                                <asp:BoundField DataField="id" HeaderText="#" />
                                <asp:BoundField DataField="tipoTarefa1.cor" HeaderText="cor" />
                                <asp:BoundField DataField="titulo" HeaderText="Titulo" />
                                <asp:BoundField DataField="descricao" HeaderText="Descricao" />
                                <asp:BoundField DataField="prazo" HeaderText="Prazo" DataFormatString="{0:dd/MM/yyyy}" />
                                <asp:BoundField DataField="tipoTarefa1.nome" HeaderText="Tipo de Tarefa" />
                                <asp:TemplateField>
                                    <ItemTemplate>                
                                        <asp:LinkButton runat="server" CommandArgument="<%# Container.DataItemIndex %>">
                                            <span class="glyphicon glyphicon-search"/>
                                        </asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
			                </Columns>
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
