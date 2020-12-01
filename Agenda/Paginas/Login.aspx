<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="Agenda.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <asp:PlaceHolder runat="server">
        <%: Scripts.Render("~/bundles/modernizr") %>
    </asp:PlaceHolder>

    <webopt:bundlereference runat="server" path="~/Content/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid box" >
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <h4 class="modal-title">Cadadstrar</h4>
                    </div>
                    <div class="modal-body modal-dialog-centered">                          
                        <div class="form-group">
                            <label>Login: </label>
                            <asp:TextBox id="txtLogin" runat="server" class="form-control"/>
                        </div>                                                
                        <div class="form-group">
                            <label>Senha: </label>
                            <asp:TextBox ID="txtSenha" TextMode="Password" runat="server" class="form-control" />
                        </div>                                                
                        <div class="form-group">
                            <asp:Button ID="btnEntrar" Text="Entrar" runat="server" class="btn btn-primary" />
                            <asp:Button ID="btnCadastrar" Text="Cadastrar" runat="server" class="btn btn-primary" />
                        </div>                        
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
