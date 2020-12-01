<%@ Page Language="vb" MasterPageFile="~/Site.Master" AutoEventWireup="false" CodeBehind="TipoTarefa.aspx.vb" Inherits="Agenda.TipoTarefa1" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid box">
        <div class="modal-dialog modal-lg" role="document">
            <div class="modal-header">
               <h2>
                  <label>Tarefa</label> 
               </h2>
            </div>
            <div class="modal-body">
                <div>
                    <asp:DataGrid ID="dtgTipoTarefa" runat="server">

                    </asp:DataGrid>
                    <div>               
                        <div class="row">
                            <div class="form-group col-md-6">
                                <label>Nome:</label>
                                <asp:TextBox ID="txtNome" class="form-control" runat="server" />
                            </div>
                            <div class="form-group col-md-6">
                                <label>Cor:</label>
                                <asp:DropDownList id="drpCor" class="form-control" runat="server"/>
                            </div>
                        </div>
                        <div class="row">
                            <div class="form-group col-md-6">
                                <asp:Button id="btnIncluir" Text="Incluir" runat="server" class="btn btn-success"/>
                                <asp:Button ID="btnVoltar" Text="Voltar" runat="server" class="btn btn-secondary"/>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
     </div>
</asp:Content>